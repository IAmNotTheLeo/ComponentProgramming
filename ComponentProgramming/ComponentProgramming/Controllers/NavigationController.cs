using ComponentProgramming.Models;
using ComponentProgramming.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentProgramming.Controllers
{
    class NavigationController
    {
        private NavigationView view;
        private Form curForm;

        public NavigationController(NavigationView view, Form curForm)
        {
            this.view = view;
            this.curForm = curForm;
            this.view.GoBack.Click += (sender, e) => goBackBtn_Click(sender, e);
            this.view.LogoutBtn.Click += (sender, e) => logoutBtn_Click(sender, e);
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            MVCForm.DisposeView(view);
            AdminDashboard adminDashboard = new AdminDashboard();
            AdminDashboardView adminDashboardView = new AdminDashboardView();
            AdminDashboardController adminDashboardController = new AdminDashboardController(adminDashboard, adminDashboardView, this.curForm);
            adminDashboardController.DisplayView();
            adminDashboardController.DisplayNavigation();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MVCForm.DisposeView(this.view);
            Login loginModel = new Login();
            LoginView loginView = new LoginView();
            LoginController loginController = new LoginController(loginModel, loginView, this.curForm);
            loginController.DisplayView();
        }

        public void DisplayView()
        {
            view.SetUpControlls(this.curForm);
        }
    }
}
