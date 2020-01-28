using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomControlls;
using System.Windows.Forms;

namespace ComponentProgramming.Models
{
    class Dashboard
    {
        CustomLabel lblFirstName = new CustomLabel();
        CustomLabel lblSurname = new CustomLabel();
        CustomLabel lblAddress = new CustomLabel();
        CustomLabel lblEmail = new CustomLabel();
        CustomLabel lblPassword = new CustomLabel();
        CustomLabel lblPhone = new CustomLabel();
        CustomLabel lblDepartment = new CustomLabel();
        CustomTextBox2 txtFirstName = new CustomTextBox2();
        CustomTextBox2 txtSurname = new CustomTextBox2();
        CustomTextBox2 txtAddress = new CustomTextBox2();
        CustomTextBox2 txtEmail = new CustomTextBox2();
        CustomTextBox2 txtPassword = new CustomTextBox2();
        CustomTextBox3 txtPhone = new CustomTextBox3();
        ComboBox comboDepartment = new ComboBox();

        public CustomTextBox2 TxtFirstName { get => txtFirstName; set => txtFirstName = value; }
        public CustomTextBox2 TxtSurname { get => txtSurname; set => txtSurname = value; }
        public CustomTextBox2 TxtAddress { get => txtAddress; set => txtAddress = value; }
        public CustomTextBox2 TxtEmail { get => txtEmail; set => txtEmail = value; }
        public CustomTextBox2 TxtPassword { get => txtPassword; set => txtPassword = value; }
        public CustomTextBox3 TxtPhone { get => txtPhone; set => txtPhone = value; }
        public ComboBox ComboDepartment { get => comboDepartment; set => comboDepartment = value; }
    }
}
