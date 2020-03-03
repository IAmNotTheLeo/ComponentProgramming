using System;
using System.Collections.Generic;
using System.Linq;
using Connection;
using System.Text;
using System.Threading.Tasks;
using CustomControlls;
using System.Windows.Forms;
using ComponentProgramming.Views;

namespace ComponentProgramming.Models
{
    class AddEmployee
    {
        private LINQDataContext db = new LINQDataContext();
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
        public void AddAccount(Employee employee)
        {
            db.Employees.InsertOnSubmit(employee);

            try
            {
                db.SubmitChanges();
                MessageBox.Show("Data Inserted");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
