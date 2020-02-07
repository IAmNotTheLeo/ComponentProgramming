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
        private LINQDataContext db;
        private EditEmployee model;
        private EditEmployeeView view;

        public EditEmployeeController(EditEmployee model, EditEmployeeView view)
        {
            db = new LINQDataContext();
            this.model = model;
            this.view = view;
            model.ComboName.SelectedIndexChanged += (sender, e) => comboName_SelectedIndexChanged(sender, e);
            model.BtnEdit.Click += (sender, e) => btnEdit_Click(sender, e);
            DisplayContent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditAccount();
            MessageBox.Show("Data Updated");
        }

        private void DisplayContent()
        {
            var query =  from employee in db.Employees where employee.DepartmentID != 7 select employee;
            foreach (var display in query)
            {
                model.ComboName.Items.Add(display.FullName);
            }

            var querysecond = from displayPlace in db.Departments where displayPlace.DepartmentID != 7 select displayPlace;
            model.ComboDepartment.DataSource = querysecond;
            model.ComboDepartment.DisplayMember = "Place";
            model.ComboDepartment.ValueMember = "DepartmentID";
        }

        public void EditAccount()
        {
            var query = from employeeUpdate in db.Employees where employeeUpdate.FullName == model.ComboName.Text select employeeUpdate;
                              

            foreach (Employee employee in query)
            {
                employee.EAddress = model.TxtAddress.Text;
                employee.Email = model.TxtEmail.Text;
                employee.Password = model.TxtPassword.Text;
                employee.Phone = model.TxtPhone.Text;
                employee.DepartmentID = (int)model.ComboDepartment.SelectedValue;
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {

            var query = from employee in db.Employees join department in db.Departments on employee.DepartmentID equals department.DepartmentID
                              where employee.FullName == model.ComboName.Text
                        select new
                              {
                                  EmployeeAddress = employee.EAddress,
                                  EmployeeEmail = employee.Email,
                                  EmployeePass = employee.Password,
                                  EmployeePhone = employee.Phone,
                                  DepartmentName = department.Place
                             };

            foreach (var details in query)
            {
                model.TxtAddress.Text = details.EmployeeAddress;
                model.TxtEmail.Text = details.EmployeeEmail;
                model.TxtPassword.Text = details.EmployeePass;
                model.TxtPhone.Text = details.EmployeePhone.ToString();
                model.TxtCurrentDepartment.Text = details.DepartmentName;

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
                model.TxtCurrentDepartment,
                model.LblSelect,
                model.ComboDepartment,
                model.BtnEdit, curForm);
        }
    }
}
