using ComponentProgramming.Models;
using ComponentProgramming.Views;
using CustomControlls;
using Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.Linq;

namespace ComponentProgramming.Controllers
{
    class AddEmployeeController : Display
    {
        private AddEmployee model;
        private AddEmployeeView view;
        private LINQDataContext db;
        public AddEmployeeController(AddEmployee model, AddEmployeeView view)
        {
            db = new LINQDataContext();
            this.model = model;
            this.view = view;
            view.BtnCreate.Click += (sender, e) => btnCreate_Click(sender, e);
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                FullName = view.TxtFirstName.Text + " " + view.TxtSurname.Text,
                EAddress = view.TxtAddress.Text,
                Email = view.TxtEmail.Text,
                Password = view.TxtPassword.Text,
                Phone = view.TxtPhone.Text,
                DepartmentID = (int)view.ComboDepartment.SelectedValue,
                DateJoined = DateTime.Now.ToShortDateString()
            };
            model.AddAccount(employee); 
        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(this.model.DisplayDepartment(), curForm);
        }


    }
}
