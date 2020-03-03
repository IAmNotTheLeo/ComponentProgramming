using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomControlls;
using System.Windows.Forms;
using Connection;

namespace ComponentProgramming.Models
{
    class EditEmployee
    {

        private LINQDataContext db = new LINQDataContext();
        public ComboBox DisplayEmployees()
        {
            ComboBox employees = new ComboBox();
            var query = from employee in db.Employees where employee.DepartmentID != 7 select employee;
            foreach (var display in query)
            {
                employees.Items.Add(display.FullName);
            }

            return employees;
        }

        public ComboBox DisplayDepartment()
        {
            ComboBox comboBox = new ComboBox();
            var query = from displayPlace in db.Departments where displayPlace.DepartmentID != 7 select displayPlace;
            comboBox.DataSource = query;
            comboBox.DisplayMember = "Place";
            comboBox.ValueMember = "DepartmentID";
            return comboBox;
        }

        public ComboBox DisplayRole()
        {
            ComboBox comboBox = new ComboBox();
            var query = from displayRole in db.Roles select displayRole;
            comboBox.DataSource = query;
            comboBox.DisplayMember = "Role1";
            comboBox.ValueMember = "RoleID";
            return comboBox;
        }

        public void EditAccount(string fullName,
            string address,
            string email,
            string pass,
            string phone,
            int department,
            int role)
        {
            var query = from employeeUpdate in db.Employees where employeeUpdate.FullName == fullName select employeeUpdate;

            foreach (Employee employee in query)
            {
                employee.EAddress = address;
                employee.Email = email;
                employee.Password = pass;
                employee.Phone = phone;
                employee.DepartmentID = department;
                employee.RoleID = role;
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Data Updated");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

          public string[] GetEmployeeDetails(string fullName)
        {
            string[] employeeDetails = new string[6];
            var query = from employee in db.Employees
                        join department in db.Departments on employee.DepartmentID equals department.DepartmentID
                        join role in db.Roles on employee.RoleID equals role.RoleID
                        where employee.FullName == fullName
                        select new
                        {
                            EmployeeAddress = employee.EAddress,
                            EmployeeEmail = employee.Email,
                            EmployeePass = employee.Password,
                            EmployeePhone = employee.Phone,
                            DepartmentName = department.Place,
                            RoleName = role.Role1
                        };

            foreach (var details in query)
            {
                employeeDetails[0] = details.EmployeeAddress;
                employeeDetails[1] = details.EmployeeEmail;
                employeeDetails[2] = details.EmployeePass;
                employeeDetails[3] = details.EmployeePhone.ToString();
                employeeDetails[4] = details.DepartmentName;
                employeeDetails[5] = details.RoleName;

            }

            return employeeDetails;
        }
    }
}
