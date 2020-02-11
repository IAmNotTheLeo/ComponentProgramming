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
    class EditEmployeeController : Display
    {
        private LINQDataContext db;
        private EditEmployee model;
        private EditEmployeeView view;

        public EditEmployeeController(EditEmployee model, EditEmployeeView view)
        {
            db = new LINQDataContext();
            this.model = model;
            this.view = view;
            this.view.ComboName.SelectedIndexChanged += (sender, e) => comboName_SelectedIndexChanged(sender, e);
            this.view.BtnEdit.Click += (sender, e) => btnEdit_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.model.EditAccount(view.ComboName.Text,
                view.TxtAddress.Text,
                view.TxtEmail.Text,
                view.TxtPassword.Text,
                view.TxtPhone.Text, 
                (int)view.ComboDepartment.SelectedValue);
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.view.DisplaySelectedEmployee(this.model.GetEmployeeDetails(this.view.ComboName.Text));
        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(this.model.DisplayEmployees(), this.model.DisplayDepartment(), curForm);
        }
    }
}
