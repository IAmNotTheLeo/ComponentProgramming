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
        private Form curForm;
        public AdminDashboardController(AdminDashboard model, AdminDashboardView view, Form curForm)
        {
            this.model = model;
            this.view = view;
            this.curForm = curForm;
            view.BtnViewAddEmployee.Click += (sender, e) => ButtonClick(sender, e);
            view.BtnViewEditEmployee.Click += (sender, e) => ButtonClick(sender, e);
            view.BtnViewDeleteEmployee.Click += (sender, e) => ButtonClick(sender, e);
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            string clickedButton = (sender as Button).Text;
            
            switch(clickedButton)
            {
                case "Add Employee":
                    MVCForm.DisposeView(this.view);
                    AddEmployee addEmployeeDashboard = new AddEmployee();
                    AddEmployeeView addEmployeeView = new AddEmployeeView();
                    AddEmployeeController addEmployeeController = new AddEmployeeController(addEmployeeDashboard, addEmployeeView, this.curForm);
                    addEmployeeController.DisplayView();
                    break;

                case "Edit Employee":
                    MVCForm.DisposeView(this.view);
                    EditEmployee editEmployeeDashboard = new EditEmployee();
                    EditEmployeeView editEmployeeView = new EditEmployeeView();
                    EditEmployeeController editEmployeeController = new EditEmployeeController(editEmployeeDashboard, editEmployeeView, this.curForm);
                    editEmployeeController.DisplayView();
                    break;

                case "Delete Employee":
                    MVCForm.DisposeView(this.view);
                    DeleteEmployee deleteEmployeeDashboard = new DeleteEmployee();
                    DeleteEmployeeView deleteEmployeeView = new DeleteEmployeeView();
                    DeleteEmployeeController deleteEmployeeController = new DeleteEmployeeController(deleteEmployeeDashboard, deleteEmployeeView, this.curForm);
                    deleteEmployeeController.DisplayView();
                    break;
            }
        }

        public void DisplayView()
        {
            this.view.SetUpControlls(view.BtnViewAddEmployee, view.BtnViewEditEmployee, view.BtnViewDeleteEmployee, this.curForm);
        }
    }
}
