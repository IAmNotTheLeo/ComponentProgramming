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

        public LoginController(Login model, LoginView view)
        {
            this.model = model;
            this.view = view;
        }

        public CustomTextBox UsernameBox { get => model.UsernameBox; set => model.UsernameBox = value; }
        public CustomTextBox2 PasswordBox { get => model.PasswordBox; set => model.PasswordBox = value; }
        public CustomLabel UsernameLbl { get => model.UsernameLbl; set => model.UsernameLbl = value; }
        public CustomLabel PasswordLbl { get => model.PasswordLbl; set => model.PasswordLbl = value; }
        public CustomButton LoginBtn { get => model.LoginBtn; set => model.LoginBtn = value; }

        public static void ButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine("Btn click");
        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(model.UsernameBox, model.PasswordLbl, model.UsernameLbl, model.LoginBtn, model.PasswordBox, curForm);
        }
    }
}
