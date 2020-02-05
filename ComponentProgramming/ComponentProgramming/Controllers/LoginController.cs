using ComponentProgramming.Models;
using ComponentProgramming.Views;
using CustomControlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentProgramming.Controllers
{
    class LoginController
    {
        private Login model;
        private LoginView view;


        public LoginController()
        {

        }
        public LoginController(Login model, LoginView view)
        {
            this.model = model;
            this.view = view;
            model.LoginBtn.Click += (sender, e) => ButtonClick(sender, e);
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            AdminController.LoginValidation(model.UsernameBox.Text, model.PasswordBox.Text);
        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(model.UsernameBox, 
                model.PasswordLbl, 
                model.UsernameLbl, 
                model.LoginBtn, 
                model.PasswordBox, curForm);
        }
    }
}
