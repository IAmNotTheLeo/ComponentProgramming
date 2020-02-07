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
    class DeleteEmployeeController
    {
        private LINQDataContext db;
        private DeleteEmployee model;
        private DeleteEmployeeView view;
        public DeleteEmployeeController(DeleteEmployee model, DeleteEmployeeView view)
        {
            db = new LINQDataContext();
            this.model = model;
            this.view = view;
            model.BtnDelete.Click += (sender, e) => btnDelete_Click(sender, e);
            model.ComboName.SelectedIndexChanged += (sender, e) => comboName_SelectedIndexChanged(sender, e);
            DisplayEmployee();
        }

        private void DeleteEmployee()
        {
            var query = from deleteEmployee in db.Employees where deleteEmployee.FullName == model.ComboName.Text select deleteEmployee;

            foreach (var command in query)
            {
                db.Employees.DeleteOnSubmit(command);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteEmployee();
            MessageBox.Show("Data Deleted");
        }

        private void DisplayEmployee()
        {
            var query = from employee in db.Employees where employee.DepartmentID != 7 select employee;
            foreach (var display in query)
            {
                model.ComboName.Items.Add(display.FullName);
            }
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = from employee in db.Employees
                        join department in db.Departments on employee.DepartmentID equals department.DepartmentID
                        where employee.FullName == model.ComboName.Text
                        select new
                        {
                            EmployeeAddress = employee.EAddress,
                            EmployeeEmail = employee.Email,
                            EmployeePhone = employee.Phone,
                            DepartmentName = department.Place
                        };

            if (model.ComboName.Items.Count != 1)
            {
                model.RichtxtDetails.Clear();
            }

            foreach (var details in query)
            {
                model.RichtxtDetails.AppendText(
                    "Employee Address: \n" + details.EmployeeAddress + "\n\n" +
                    "Employee Email: \n" + details.EmployeeEmail + "\n\n" +
                    "Employee Phone: \n" + details.EmployeePhone + "\n\n" +
                    "Department: \n" + details.DepartmentName + "\n\n");
            }
        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(model.LblName,
                model.ComboName,
                model.RichtxtDetails,
                model.BtnDelete, curForm);
        }
    }
}
