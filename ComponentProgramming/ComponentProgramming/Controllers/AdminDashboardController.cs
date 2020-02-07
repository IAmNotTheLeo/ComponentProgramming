using Connection;
using ComponentProgramming.Models;
using ComponentProgramming.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControlls;

namespace ComponentProgramming.Controllers
{
    class AdminDashboardController
    {
        private AdminDashboard model;
        private AdminDashboardView view;
        public AdminDashboardController(AdminDashboard model, AdminDashboardView view)
        {
            this.model = model;
            this.view = view;
            model.BtnViewAddEmployee.Click += (sender, e) => btnViewAddEmployee_Click(sender, e);
        }

        private void btnViewAddEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        internal void DisplayView(Form curForm)
        {
            view.SetUpControlls(model.BtnViewAddEmployee, model.BtnViewEditEmployee, model.BtnViewDeleteEmployee, curForm);
        }
    }
}
