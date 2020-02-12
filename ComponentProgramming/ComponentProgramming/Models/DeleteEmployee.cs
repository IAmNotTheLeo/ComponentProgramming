using CustomControlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection;

namespace ComponentProgramming.Models
{
    class DeleteEmployee
    {
        LINQDataContext db = new LINQDataContext();
        String employeeDetails;

        public void DeleteAccount(string fullName)
        {
        var query = from deleteEmployee in db.Employees where deleteEmployee.FullName == fullName select deleteEmployee;

            foreach (var command in query)
            {
                db.Employees.DeleteOnSubmit(command);
            }

            try
            {
                db.SubmitChanges();
                MessageBox.Show("Data Deleted");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public ComboBox DisplayEmployees()
        {
            ComboBox comboBox = new ComboBox();
            var query = from employee in db.Employees where employee.DepartmentID != 7 select employee;
            foreach (var display in query)
            {
                comboBox.Items.Add(display.FullName);
            }

            return comboBox;
        }

        public string GetEmployeeDetails(string fullName)
        {
            
            var query = from employee in db.Employees
                        join department in db.Departments on employee.DepartmentID equals department.DepartmentID
                        where employee.FullName == fullName
                        select new
                        {
                            EmployeeAddress = employee.EAddress,
                            EmployeeEmail = employee.Email,
                            EmployeePhone = employee.Phone,
                            DepartmentName = department.Place
                        };
            
            foreach (var details in query)
            {
                employeeDetails = 
                    "Employee Address: \n" + details.EmployeeAddress + "\n\n" +
                    "Employee Email: \n" + details.EmployeeEmail + "\n\n" +
                    "Employee Phone: \n" + details.EmployeePhone + "\n\n" +
                    "Department: \n" + details.DepartmentName + "\n\n";
            }

            return employeeDetails;
        }

        
    }
}
