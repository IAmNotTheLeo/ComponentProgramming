using ComponentProgramming.Models;
using ComponentProgramming.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentProgramming.Controllers
{
    class AdminController
    {
        private Admin model;
        private AdminView view;

        public AdminController(Admin model, AdminView view)
        {
            this.model = model;
            this.view = view;
        }

        public void UpdateView()
        {

        }
    }
}
