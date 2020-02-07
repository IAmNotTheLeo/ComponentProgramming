using ComponentProgramming.Models;
using ComponentProgramming.Views;
using Connection;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComponentProgramming.Controllers
{
    class AdminController
    {
        private Admin model;
        
        public AdminController(Admin model)
        {
            this.model = model;
        }

        public static bool LoginValidation(String email, String password)
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
