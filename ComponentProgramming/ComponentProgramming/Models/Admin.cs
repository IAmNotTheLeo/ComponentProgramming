using Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentProgramming.Models
{
    class Admin
    {
        public bool LoginValidation(String email, String password)
        {
            LINQDataContext db = new LINQDataContext();
            var query = from user in db.Employees where user.Email == email && user.Password == password && user.DepartmentID == 7 select user;

            if (query.Any())
            {
                MessageBox.Show("Correct");
                return true;
            }
            else
            {
                MessageBox.Show("Wrong");
                return false;
            }
        }
    }
}
