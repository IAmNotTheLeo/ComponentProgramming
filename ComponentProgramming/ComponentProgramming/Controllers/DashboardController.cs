using ComponentProgramming.Models;
using ComponentProgramming.Views;
using CustomControlls;
using Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ComponentProgramming.Controllers
{
    class DashboardController
    {
        private Dashboard model;
        private DashboardView view;

        public CustomLabel LblFirstName { get => model.LblFirstName; set => LblFirstName = value; }
        public CustomLabel LblSurname { get => model.LblSurname; set => LblSurname = value; }
        public CustomLabel LblAddress { get => model.LblAddress; set => LblAddress = value; }
        public CustomLabel LblEmail { get => model.LblEmail; set => LblEmail = value; }
        public CustomLabel LblPassword { get => model.LblPassword; set => LblPassword = value; }
        public CustomLabel LblPhone { get => model.LblPhone; set => LblPhone = value; }
        public CustomLabel LblDepartment { get => model.LblDepartment; set => LblDepartment = value; }
        public CustomTextBox2 TxtFirstName { get => model.TxtFirstName; set => TxtFirstName = value; }
        public CustomTextBox2 TxtSurname { get => model.TxtSurname; set => TxtSurname = value; }
        public CustomTextBox2 TxtAddress { get => model.TxtAddress; set => TxtAddress = value; }
        public CustomTextBox2 TxtEmail { get => model.TxtEmail; set => TxtEmail = value; }
        public CustomTextBox2 TxtPassword { get => model.TxtPassword; set => TxtPassword = value; }
        public CustomTextBox3 TxtPhone { get => model.TxtPhone; set => TxtPhone = value; }
        public CustomButton BtnCreate { get => model.BtnCreate; set => BtnCreate = value; }
        public ComboBox ComboDepartment { get => model.ComboDepartment; set => ComboDepartment = value; }

        public DashboardController(Dashboard model, DashboardView view)
        {
            this.model = model;
            this.view = view;
        }

        public static void btnCreate_Click(object sender, EventArgs e)
        {

        }

        public void DisplayView(Form curForm)
        {
            view.SetUpControlls(LblFirstName, LblSurname, LblAddress, LblEmail, LblPassword, LblPhone, LblDepartment, TxtFirstName, TxtSurname, TxtAddress, TxtEmail, TxtPassword, TxtPhone, ComboDepartment, BtnCreate, curForm);
        }


    }
}
