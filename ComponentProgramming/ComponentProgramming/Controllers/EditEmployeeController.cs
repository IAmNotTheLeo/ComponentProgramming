using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentProgramming.Models;
using ComponentProgramming.Views;
using Connection;


namespace ComponentProgramming.Controllers
{
    class EditEmployeeController
    {
        private EditEmployee model;
        private EditEmployeeView view;

        public EditEmployeeController(EditEmployee model, EditEmployeeView view)
        {
            this.model = model;
            this.view = view;
            model.ComboName.SelectedIndexChanged += (sender, e) => comboName_SelectedIndexChanged(sender, e);
            DisplayEmployeesDetails();
        }

        public void DisplayEmployeesDetails()
        {
            LINQDataContext db = new LINQDataContext();
            var query = from displayEmployee in db.Employees where displayEmployee.DepartmentID != 7 select displayEmployee;
            model.ComboName.DataSource = query;
            model.ComboName.DisplayMember = "FirstName";
            
            var querysecond = from displayDepartment in db.Departments select displayDepartment;
            model.ComboDepartment.DataSource = querysecond;
            model.ComboDepartment.DisplayMember = "Place";
            model.ComboDepartment.ValueMember = "DepartmentID";
        }

        public void EditAccount()
        {
            using (LINQDataContext db = new LINQDataContext())
            {

            }
        }

        public void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LINQDataContext db = new LINQDataContext();
            var querysecond = from displayDetail in db.Employees where displayDetail.FirstName == model.ComboName.Text select displayDetail;
            foreach (var details in querysecond)
            {
                model.TxtAddress.Text = details.EAddress;
                model.TxtEmail.Text = details.Email;
                model.TxtPassword.Text = details.Password;
                model.TxtPhone.Text = details.Phone.ToString();
                
                
            }
            
        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(model.LblName,
                model.LblAddress,
                model.LblEmail,
                model.LblPassword,
                model.LblPhone,
                model.LblDepartment,
                model.ComboName,
                model.TxtAddress,
                model.TxtEmail,
                model.TxtPassword,
                model.TxtPhone,
                model.ComboDepartment,
                model.BtnEdit, curForm);
        }
    }
}
