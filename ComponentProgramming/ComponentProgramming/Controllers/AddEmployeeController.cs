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
    class AddEmployeeController
    {
        private AddEmployee model;
        private AddEmployeeView view;
        private LINQDataContext db;
        public AddEmployeeController(AddEmployee model, AddEmployeeView view)
        {
            db = new LINQDataContext();
            this.model = model;
            this.view = view;
            model.BtnCreate.Click += (sender, e) => btnCreate_Click(sender, e);
            DisplayDepartment();
        }

        public void DisplayDepartment()
        {
            
            var query = from displayPlace in db.Departments where displayPlace.DepartmentID != 7 select displayPlace;
            model.ComboDepartment.DataSource = query;
            model.ComboDepartment.DisplayMember = "Place";
            model.ComboDepartment.ValueMember = "DepartmentID";
        }
        public void AddAccount()
        {            
                Employee test = new Employee
                {
                    FirstName = model.TxtFirstName.Text,
                    Surname = model.TxtSurname.Text,
                    EAddress = model.TxtAddress.Text,
                    Email = model.TxtEmail.Text,
                    Password = model.TxtPassword.Text,
                    Phone = model.TxtPhone.Text,
                    DepartmentID = (int)model.ComboDepartment.SelectedValue,
                    DateJoined = DateTime.Now.ToShortDateString()
                };
                
                db.Employees.InsertOnSubmit(test);

            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void btnCreate_Click(object sender, EventArgs e)
        {
            AddAccount();
            MessageBox.Show("Data Inserted");
        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(model.LblFirstName,
                model.LblSurname,
                model.LblAddress,
                model.LblEmail,
                model.LblPassword,
                model.LblPhone,
                model.LblDepartment,
                model.TxtFirstName,
                model.TxtSurname,
                model.TxtAddress,
                model.TxtEmail,
                model.TxtPassword,
                model.TxtPhone,
                model.ComboDepartment,
                model.BtnCreate, curForm);
        }


    }
}
