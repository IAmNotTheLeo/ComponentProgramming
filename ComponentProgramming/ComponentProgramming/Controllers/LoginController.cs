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
    class LoginController : Display
    {
        private Login model;
        private LoginView view;

        public LoginController(Login model, LoginView view)
        {
            this.model = model;
            this.view = view;
            this.view.LoginBtn.Click += (sender, e) => ButtonClick(sender, e);
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            this.model.LoginValidation(this.view.UsernameBox.Text, this.view.PasswordBox.Text);
        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(curForm);
        }
    }
}
