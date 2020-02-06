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
    class DeleteEmployeeController
    {
        private LINQDataContext db;
        private DeleteEmployee model;
        private DeleteEmployeeView view;
        public DeleteEmployeeController(DeleteEmployee model, DeleteEmployeeView view)
        {
            db = new LINQDataContext();
            this.model = model;
            this.view = view;
            model.BtnDelete.Click += (sender, e) => btnDelete_Click(sender, e);
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
