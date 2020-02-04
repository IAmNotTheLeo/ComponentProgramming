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
            LoginBtn.Click += (sender, e) => ButtonClick(sender, e);
        }

        public CustomTextBox UsernameBox { get => model.UsernameBox; set => model.UsernameBox = value; }
        public CustomTextBox2 PasswordBox { get => model.PasswordBox; set => model.PasswordBox = value; }
        public CustomLabel UsernameLbl { get => model.UsernameLbl; set => model.UsernameLbl = value; }
        public CustomLabel PasswordLbl { get => model.PasswordLbl; set => model.PasswordLbl = value; }
        public CustomButton LoginBtn { get => model.LoginBtn; set => model.LoginBtn = value; }


        public void ButtonClick(object sender, EventArgs e)
        {
            AdminController.LoginValidation(UsernameBox.Text, PasswordBox.Text);
        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(UsernameBox, PasswordLbl, UsernameLbl, LoginBtn, PasswordBox, curForm);
        }
    }
}
