using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControlls;
using Connection;

namespace ComponentProgramming.Models
{
    class Login
    {
        private LINQDataContext db;
        public bool LoginValidation(String email, String password)
        {
            db = new LINQDataContext();
            var query = from user in db.Employees where user.Email == email && user.Password == password && user.DepartmentID == 7 select user;
            
            if (query.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
