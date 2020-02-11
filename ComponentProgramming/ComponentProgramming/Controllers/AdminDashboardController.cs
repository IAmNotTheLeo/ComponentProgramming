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
    class AdminDashboardController : Display
    {
        private AdminDashboard model;
        private AdminDashboardView view;
        public AdminDashboardController(AdminDashboard model, AdminDashboardView view)
        {
            this.model = model;
            this.view = view;
            view.BtnViewAddEmployee.Click += (sender, e) => btnViewAddEmployee_Click(sender, e);
            view.BtnViewEditEmployee.Click += (sender, e) => btnViewEditEmployee_Click(sender, e);
            view.BtnViewDeleteEmployee.Click += (sender, e) => btnViewDeleteEmployee_Click(sender, e);
        }
        private void btnViewAddEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test1");
        }

        private void btnViewEditEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test2");
        }

        private void btnViewDeleteEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test3");
        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(view.BtnViewAddEmployee, view.BtnViewEditEmployee, view.BtnViewDeleteEmployee, curForm);
        }
    }
}
