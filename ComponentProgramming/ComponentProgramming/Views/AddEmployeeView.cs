using ComponentProgramming.Controllers;
using CustomControlls;
using System;
using System.Drawing;
using System.Windows.Forms;
using ComponentProgramming.Models;

namespace ComponentProgramming.Views
{
    class AddEmployeeView : Panel
    {

        private CustomLabel lblFirstName = new CustomLabel();
        private CustomLabel lblSurname = new CustomLabel();
        private CustomLabel lblAddress = new CustomLabel();
        private CustomLabel lblEmail = new CustomLabel();
        private CustomLabel lblPassword = new CustomLabel();
        private CustomLabel lblPhone = new CustomLabel();
        private CustomLabel lblDepartment = new CustomLabel();
        private CustomTextBox2 txtFirstName = new CustomTextBox2();
        private CustomTextBox2 txtSurname = new CustomTextBox2();
        private CustomTextBox2 txtAddress = new CustomTextBox2();
        private CustomTextBox2 txtEmail = new CustomTextBox2();
        private CustomTextBox2 txtPassword = new CustomTextBox2();
        private CustomTextBox3 txtPhone = new CustomTextBox3();
        private CustomButton btnCreate = new CustomButton();
        private ComboBox comboDepartment = new ComboBox();

        public CustomLabel LblFirstName { get => lblFirstName; set => lblFirstName = value; }
        public CustomLabel LblSurname { get => lblSurname; set => lblSurname = value; }
        public CustomLabel LblAddress { get => lblAddress; set => lblAddress = value; }
        public CustomLabel LblEmail { get => lblEmail; set => lblEmail = value; }
        public CustomLabel LblPassword { get => lblPassword; set => lblPassword = value; }
        public CustomLabel LblPhone { get => lblPhone; set => lblPhone = value; }
        public CustomLabel LblDepartment { get => lblDepartment; set => lblDepartment = value; }
        public CustomTextBox2 TxtFirstName { get => txtFirstName; set => txtFirstName = value; }
        public CustomTextBox2 TxtSurname { get => txtSurname; set => txtSurname = value; }
        public CustomTextBox2 TxtAddress { get => txtAddress; set => txtAddress = value; }
        public CustomTextBox2 TxtEmail { get => txtEmail; set => txtEmail = value; }
        public CustomTextBox2 TxtPassword { get => txtPassword; set => txtPassword = value; }
        public CustomTextBox3 TxtPhone { get => txtPhone; set => txtPhone = value; }
        public CustomButton BtnCreate { get => btnCreate; set => btnCreate = value; }
        public ComboBox ComboDepartment { get => comboDepartment; set => comboDepartment = value; }
        public void SetUpControlls(ComboBox departmentList, Form curForm)
        {
            BackColor = Color.LightGray;
            Size = curForm.Size;
            Dock = DockStyle.Bottom;

            lblFirstName.Text = "First Name";
            lblFirstName.AutoSize = true;

            lblSurname.Text = "Surname";
            lblSurname.AutoSize = true;

            lblAddress.Text = "Address";
            lblAddress.AutoSize = true;

            lblEmail.Text = "Email Address";
            lblEmail.AutoSize = true;

            lblPassword.Text = "Password";
            lblPassword.AutoSize = true;
            txtPassword.PasswordChar = '*';

            lblPhone.Text = "Phone";
            lblPhone.AutoSize = true;

            lblDepartment.Text = "Department";
            lblDepartment.AutoSize = true;
            comboDepartment.Font = new Font("Microsoft Sans Serif", 12);
            comboDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDepartment.DataSource = departmentList.DataSource;
            comboDepartment.DisplayMember = departmentList.DisplayMember;
            comboDepartment.ValueMember = departmentList.ValueMember;

            btnCreate.Text = "Create Account";

            curForm.Controls.Add(this);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);

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
            Controls.Add(comboDepartment);

            Controls.Add(btnCreate);

            SetPositions();

        }

        private void SetPositions()
        {

            lblFirstName.Location = new Point((Width - lblFirstName.Width) / 2, 100);
            lblFirstName.Anchor = AnchorStyles.None;

            txtFirstName.Location = new Point((Width - txtFirstName.Width) / 2,
                txtFirstName.Height + lblFirstName.Top + 5);
            txtFirstName.Anchor = AnchorStyles.None;

            lblSurname.Location = new Point((Width - lblSurname.Width) / 2,
                lblSurname.Height + txtFirstName.Top + 5);
            lblSurname.Anchor = AnchorStyles.None;

            txtSurname.Location = new Point((Width - txtSurname.Width) / 2,
                txtSurname.Height + lblSurname.Top + 5);
            txtSurname.Anchor = AnchorStyles.None;

            lblAddress.Location = new Point((Width - lblAddress.Width) / 2,
                lblAddress.Height + txtSurname.Top + 5);
            lblAddress.Anchor = AnchorStyles.None;

            txtAddress.Location = new Point((Width - txtAddress.Width) / 2,
                txtAddress.Height + lblAddress.Top + 5);
            txtAddress.Anchor = AnchorStyles.None;

            lblEmail.Location = new Point((Width - lblEmail.Width) / 2,
                lblEmail.Height + txtAddress.Top + 5);
            lblEmail.Anchor = AnchorStyles.None;

            txtEmail.Location = new Point((Width - txtEmail.Width) / 2,
                txtEmail.Height + lblEmail.Top + 5);
            txtEmail.Anchor = AnchorStyles.None;

            lblPassword.Location = new Point((Width - lblPassword.Width) / 2,
                lblPassword.Height + txtEmail.Top + 5);
            lblPassword.Anchor = AnchorStyles.None;

            txtPassword.Location = new Point((Width - txtPassword.Width) / 2, 
                txtPassword.Height + lblPassword.Top + 5);
            txtPassword.Anchor = AnchorStyles.None;

            lblPhone.Location = new Point((Width - lblPhone.Width) / 2,
                lblPhone.Height + txtPassword.Top + 5);
            lblPhone.Anchor = AnchorStyles.None;

            txtPhone.Location = new Point((Width - txtPhone.Width) / 2,
                txtPhone.Height + lblPhone.Top + 5);
            txtPhone.Anchor = AnchorStyles.None;

            lblDepartment.Location = new Point((Width - lblDepartment.Width) / 2,
                lblDepartment.Height + txtPhone.Top + 5);
            lblDepartment.Anchor = AnchorStyles.None;

            comboDepartment.Location = new Point((Width - comboDepartment.Width) / 2,
                comboDepartment.Height + lblDepartment.Top + 5);
            comboDepartment.Anchor = AnchorStyles.None;

            btnCreate.Location = new Point((Width - btnCreate.Width) / 2,
                btnCreate.Height + comboDepartment.Top + 5);
            btnCreate.Anchor = AnchorStyles.None;

        }
    }
}
