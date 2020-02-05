using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomControlls;
using System.Windows.Forms;

namespace ComponentProgramming.Models
{
    class EditEmployee
    {
        CustomLabel lblName = new CustomLabel();
        ComboBox comboName = new ComboBox();
        CustomLabel lblAddress = new CustomLabel();
        CustomLabel lblEmail = new CustomLabel();
        CustomLabel lblPassword = new CustomLabel();
        CustomLabel lblPhone = new CustomLabel();
        CustomLabel lblDepartment = new CustomLabel();
        CustomTextBox2 txtname = new CustomTextBox2();
        CustomTextBox2 txtAddress = new CustomTextBox2();
        CustomTextBox2 txtEmail = new CustomTextBox2();
        CustomTextBox2 txtPassword = new CustomTextBox2();
        CustomTextBox3 txtPhone = new CustomTextBox3();
        ComboBox comboDepartment = new ComboBox();
        CustomButton btnEdit = new CustomButton();

        public CustomLabel LblName { get => lblName; set => lblName = value; }
        public ComboBox ComboName { get => comboName; set => comboName = value; }
        public CustomLabel LblAddress { get => lblAddress; set => lblAddress = value; }
        public CustomLabel LblEmail { get => lblEmail; set => lblEmail = value; }
        public CustomLabel LblPassword { get => lblPassword; set => lblPassword = value; }
        public CustomLabel LblPhone { get => lblPhone; set => lblPhone = value; }
        public CustomLabel LblDepartment { get => lblDepartment; set => lblDepartment = value; }
        public CustomTextBox2 Txtname { get => txtname; set => txtname = value; }
        public CustomTextBox2 TxtAddress { get => txtAddress; set => txtAddress = value; }
        public CustomTextBox2 TxtEmail { get => txtEmail; set => txtEmail = value; }
        public CustomTextBox2 TxtPassword { get => txtPassword; set => txtPassword = value; }
        public CustomTextBox3 TxtPhone { get => txtPhone; set => txtPhone = value; }
        public ComboBox ComboDepartment { get => comboDepartment; set => comboDepartment = value; }
        public CustomButton BtnEdit { get => btnEdit; set => btnEdit = value; }
    }
}
