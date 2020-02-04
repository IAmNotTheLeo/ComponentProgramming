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
        private AdminView view;


        private AdminController()
        {

        }
        
        public AdminController(Admin model, AdminView view)
        {
            this.model = model;
            this.view = view;
        }

        public static bool LoginValidation(String email, String password)
        {
            LINQDataContext db = new LINQDataContext();
            var query = from user in db.Employees where user.Email == email && user.Password == password select user;

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
