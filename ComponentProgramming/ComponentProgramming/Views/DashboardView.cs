using ComponentProgramming.Controllers;
using CustomControlls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComponentProgramming.Views
{
    class DashboardView : Panel
    {
        public void SetUpControlls(CustomLabel lblNumberID, 
            CustomLabel lblfirstName,
            CustomLabel lblSurname,
            CustomLabel lblAddress,
            CustomLabel lblEmail,
            CustomLabel lblPassword,
            CustomLabel lblPhone,
            CustomLabel lblDepartment,
            CustomTextBox2 txtfirstName, 
            CustomTextBox2 txtSurname, 
            CustomTextBox2 txtAddress, 
            CustomTextBox2 txtEmail, 
            CustomTextBox2 txtPassword, 
            CustomTextBox3 txtPhone, 
            ComboBox comboboxDepartment,
            CustomButton btnCreate,
            Form curForm)
        {
            BackColor = Color.Red;
            Dock = DockStyle.Bottom;

            lblfirstName.Text = "First Name:";
            lblSurname.Text = "Surname:";
            lblAddress.Text = "Address:";
            lblEmail.Text = "Email Address:";
            lblPassword.Text = "Password:";
            lblPhone.Text = "Phone:";
            lblDepartment.Text = "Department:";

            curForm.Controls.Add(this);
            Controls.Add(lblfirstName);
            Controls.Add(lblSurname);
            Controls.Add(lblAddress);
            Controls.Add(lblEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblPhone);
            Controls.Add(lblDepartment);

            SetPositions(lblNumberID, lblfirstName, lblSurname, lblAddress, lblEmail, lblPassword, lblPhone, lblDepartment, txtfirstName, txtSurname, txtAddress, txtEmail, txtPassword, txtPhone, comboboxDepartment, btnCreate);

        }

        private void SetPositions(CustomLabel lblNumberID,
            CustomLabel lblfirstName,
            CustomLabel lblSurname,
            CustomLabel lblAddress,
            CustomLabel lblEmail,
            CustomLabel lblPassword,
            CustomLabel lblPhone,
            CustomLabel lblDepartment,
            CustomTextBox2 txtfirstName,
            CustomTextBox2 txtSurname,
            CustomTextBox2 txtAddress,
            CustomTextBox2 txtEmail,
            CustomTextBox2 txtPassword,
            CustomTextBox3 txtPhone,
            ComboBox comboboxDepartment,
            CustomButton btnCreate)
        {
            //lblNumberID.Location = new Point();
        }
    }
}
