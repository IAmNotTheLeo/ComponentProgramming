using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentProgramming.Models;
using ComponentProgramming.Views;
using Connection;

namespace ComponentProgramming.Controllers
{
    class DeleteEmployeeController : Display
    {
        private LINQDataContext db;
        private DeleteEmployee model;
        private DeleteEmployeeView view;
        private Form curForm;
        public DeleteEmployeeController(DeleteEmployee model, DeleteEmployeeView view, Form curForm)
        {
            db = new LINQDataContext();
            this.model = model;
            this.view = view;
            this.curForm = curForm;
            this.view.BtnDelete.Click += (sender, e) => btnDelete_Click(sender, e);
            this.view.ComboName.SelectedIndexChanged += (sender, e) => comboName_SelectedIndexChanged(sender, e);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.model.DeleteAccount(this.view.ComboName.Text);
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.view.DisplaySelectedEmployee(this.model.GetEmployeeDetails(this.view.ComboName.Text));
        }

        public void DisplayView()
        {
            view.SetUpControlls(this.model.DisplayEmployees(), this.curForm);
        }
    }
}
