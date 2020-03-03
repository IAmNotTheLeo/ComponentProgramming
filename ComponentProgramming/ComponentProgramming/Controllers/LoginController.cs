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
        private Form curForm;

        public LoginController(Login model, LoginView view, Form curForm)
        {
            this.model = model;
            this.view = view;
            this.curForm = curForm;
            this.view.LoginBtn.Click += (sender, e) => ButtonClick(sender, e);
        }

        public void ButtonClick(object sender, EventArgs e)
        {
            if (this.model.LoginValidation(this.view.UsernameBox.Text, this.view.PasswordBox.Text))
            {
                MVCForm.DisposeView(this.view);
                AdminDashboard adminDashboard = new AdminDashboard();
                AdminDashboardView adminDashboardView = new AdminDashboardView();
                AdminDashboardController adminDashboardController = new AdminDashboardController(adminDashboard, adminDashboardView, this.curForm);
                adminDashboardController.DisplayView();
                adminDashboardController.DisplayNavigation();
            }
        }

        public void DisplayView()
        {
            this.view.SetUpControlls(this.curForm);
        }
    }
}
