using ComponentProgramming.Controllers;
using CustomControlls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComponentProgramming.Views
{
    class AddEmployeeView : Panel
    {
        public void SetUpControlls(CustomLabel lblfirstName,
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
            BackColor = Color.LightGray;
            Size = curForm.Size;
            Dock = DockStyle.Bottom;

            lblfirstName.Text = "First Name:";
            lblfirstName.AutoSize = true;

            lblSurname.Text = "Surname:";
            lblSurname.AutoSize = true;

            lblAddress.Text = "Address:";
            lblAddress.AutoSize = true;

            lblEmail.Text = "Email Address:";
            lblEmail.AutoSize = true;

            lblPassword.Text = "Password:";
            lblPassword.AutoSize = true;
            txtPassword.PasswordChar = '*';

            lblPhone.Text = "Phone:";
            lblPhone.AutoSize = true;

            lblDepartment.Text = "Department";
            lblDepartment.AutoSize = true;
            comboboxDepartment.Font = new Font("Microsoft Sans Serif", 12);
            comboboxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;

            btnCreate.Text = "Create Account";

            curForm.Controls.Add(this);
            Controls.Add(lblfirstName);
            Controls.Add(txtfirstName);

            Controls.Add(lblSurname);
            Controls.Add(txtSurname);

            Controls.Add(lblAddress);
            Controls.Add(txtAddress);

            Controls.Add(lblEmail);
            Controls.Add(txtEmail);

            Controls.Add(lblPassword);
            Controls.Add(txtPassword);

            Controls.Add(lblPhone);
            Controls.Add(txtPhone);

            Controls.Add(lblDepartment);
            Controls.Add(comboboxDepartment);

            Controls.Add(btnCreate);

            SetPositions(lblfirstName, lblSurname, lblAddress, lblEmail, lblPassword, lblPhone, lblDepartment, txtfirstName, txtSurname, txtAddress, txtEmail, txtPassword, txtPhone, comboboxDepartment, btnCreate);

        }

        private void SetPositions(CustomLabel lblfirstName,
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

            lblfirstName.Location = new Point((Width - lblfirstName.Width * 2 + 30) / 2,
                Height / 5 - lblfirstName.Height / 2 - 60);
            lblfirstName.Anchor = AnchorStyles.None;

            txtfirstName.Location = new Point((Width - txtfirstName.Width) / 2,
                txtfirstName.Height + lblfirstName.Top + 5);
            txtfirstName.Anchor = AnchorStyles.None;

            lblSurname.Location = new Point((Width - lblSurname.Width * 2 - 17) / 2,
                lblSurname.Height + txtfirstName.Top + 5);
            lblSurname.Anchor = AnchorStyles.None;

            txtSurname.Location = new Point((Width - txtSurname.Width) / 2,
                txtSurname.Height + lblSurname.Top + 5);
            txtSurname.Anchor = AnchorStyles.None;

            lblAddress.Location = new Point((Width - lblAddress.Width * 2 - 20) / 2,
                lblAddress.Height + txtSurname.Top + 5);
            lblAddress.Anchor = AnchorStyles.None;

            txtAddress.Location = new Point((Width - txtAddress.Width) / 2,
                txtAddress.Height + lblAddress.Top + 5);
            txtAddress.Anchor = AnchorStyles.None;

            lblEmail.Location = new Point((Width - lblEmail.Width * 1 - 45) / 2,
                lblEmail.Height + txtAddress.Top + 5);
            lblEmail.Anchor = AnchorStyles.None;

            txtEmail.Location = new Point((Width - txtEmail.Width) / 2,
                txtEmail.Height + lblEmail.Top + 5);
            txtEmail.Anchor = AnchorStyles.None;

            lblPassword.Location = new Point((Width - lblPassword.Width * 2) / 2,
                lblPassword.Height + txtEmail.Top + 5);
            lblPassword.Anchor = AnchorStyles.None;

            txtPassword.Location = new Point((Width - txtPassword.Width) / 2, 
                txtPassword.Height + lblPassword.Top + 5);
            txtPassword.Anchor = AnchorStyles.None;

            lblPhone.Location = new Point((Width - lblPhone.Width * 2 - 50) / 2,
                lblPhone.Height + txtPassword.Top + 5);
            lblPhone.Anchor = AnchorStyles.None;

            txtPhone.Location = new Point((Width - txtPhone.Width) / 2,
                txtPhone.Height + lblPhone.Top + 5);
            txtPhone.Anchor = AnchorStyles.None;

            lblDepartment.Location = new Point((Width - lblDepartment.Width) / 2,
                lblDepartment.Height + txtPhone.Top + 5);
            lblDepartment.Anchor = AnchorStyles.None;

            comboboxDepartment.Location = new Point((Width - comboboxDepartment.Width) / 2,
                comboboxDepartment.Height + lblDepartment.Top + 5);
            comboboxDepartment.Anchor = AnchorStyles.None;

            btnCreate.Location = new Point((Width - btnCreate.Width) / 2,
                btnCreate.Height + comboboxDepartment.Top + 5);
            btnCreate.Anchor = AnchorStyles.None;

        }
    }
}
