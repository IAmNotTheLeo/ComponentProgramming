using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CustomControlls;
using System.Windows.Forms;
using ComponentProgramming.Models;

namespace ComponentProgramming.Views
{
    class EditEmployeeView : Panel
    {

        CustomLabel lblName = new CustomLabel();
        ComboBox comboName = new ComboBox();
        CustomLabel lblAddress = new CustomLabel();
        CustomLabel lblEmail = new CustomLabel();
        CustomLabel lblPassword = new CustomLabel();
        CustomLabel lblPhone = new CustomLabel();
        CustomLabel lblDepartment = new CustomLabel();
        CustomTextBox2 txtAddress = new CustomTextBox2();
        CustomTextBox2 txtEmail = new CustomTextBox2();
        CustomTextBox2 txtPassword = new CustomTextBox2();
        CustomTextBox3 txtPhone = new CustomTextBox3();
        CustomTextBox2 txtCurrentDepartment = new CustomTextBox2();
        CustomLabel lblSelect = new CustomLabel();
        ComboBox comboDepartment = new ComboBox();
        CustomButton btnEdit = new CustomButton();

        public CustomLabel LblName { get => lblName; set => lblName = value; }
        public ComboBox ComboName { get => comboName; set => comboName = value; }
        public CustomLabel LblAddress { get => lblAddress; set => lblAddress = value; }
        public CustomLabel LblEmail { get => lblEmail; set => lblEmail = value; }
        public CustomLabel LblPassword { get => lblPassword; set => lblPassword = value; }
        public CustomLabel LblPhone { get => lblPhone; set => lblPhone = value; }
        public CustomLabel LblDepartment { get => lblDepartment; set => lblDepartment = value; }
        public CustomTextBox2 TxtAddress { get => txtAddress; set => txtAddress = value; }
        public CustomTextBox2 TxtEmail { get => txtEmail; set => txtEmail = value; }
        public CustomTextBox2 TxtPassword { get => txtPassword; set => txtPassword = value; }
        public CustomTextBox3 TxtPhone { get => txtPhone; set => txtPhone = value; }
        public CustomTextBox2 TxtCurrentDepartment { get => txtCurrentDepartment; set => txtCurrentDepartment = value; }
        public CustomLabel LblSelect { get => lblSelect; set => lblSelect = value; }
        public ComboBox ComboDepartment { get => comboDepartment; set => comboDepartment = value; }
        public CustomButton BtnEdit { get => btnEdit; set => btnEdit = value; }

        public void SetUpControlls(ComboBox employeesList, ComboBox departmentList, Form curform)
        {
            BackColor = Color.LightGray;
            Size = curform.Size;
            Dock = DockStyle.Bottom;

            lblName.Text = "Employee Name";
            lblName.AutoSize = true;
            comboName.DropDownStyle = ComboBoxStyle.DropDownList;

            lblAddress.Text = "Address";
            lblAddress.AutoSize = true;

            lblEmail.Text = "Email Address";
            lblEmail.AutoSize = true;

            lblPassword.Text = "Password";
            lblPassword.AutoSize = true;

            lblPhone.Text = "Phone";
            lblPhone.AutoSize = true;

            lblDepartment.Text = "Department";
            lblDepartment.AutoSize = true;
            txtCurrentDepartment.ReadOnly = true;
            lblSelect.Text = "Select:";
            lblSelect.AutoSize = true;
            comboName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboName.DropDownHeight = 200;
            comboName.Font = new Font("Microsoft Sans Serif", 10);

            btnEdit.Text = "Edit Account";

            CopyComboBoxValues(employeesList);

            comboDepartment.DataSource = departmentList.DataSource;
            comboDepartment.DisplayMember = departmentList.DisplayMember;
            comboDepartment.ValueMember = departmentList.ValueMember;
            comboDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDepartment.Font = new Font("Microsoft Sans Serif", 10);

            curform.Controls.Add(this);
            Controls.Add(lblName);
            Controls.Add(comboName);

            Controls.Add(lblAddress);
            Controls.Add(txtAddress);

            Controls.Add(lblEmail);
            Controls.Add(txtEmail);

            Controls.Add(lblPassword);
            Controls.Add(txtPassword);

            Controls.Add(lblPhone);
            Controls.Add(txtPhone);

            Controls.Add(lblDepartment);
            Controls.Add(txtCurrentDepartment);
            Controls.Add(lblSelect);
            Controls.Add(comboDepartment);

            Controls.Add(btnEdit);

            SetPositions();
        }

        private void SetPositions()
        {
            lblName.Location = new Point((Width - lblName.Width) / 2,
                Height / 5 - lblName.Height / 2 - 60);
            lblName.Anchor = AnchorStyles.None;

            comboName.Location = new Point((Width - comboName.Width) / 2,
                comboName.Height + lblName.Top + 12);
            comboName.Anchor = AnchorStyles.None;

            lblAddress.Location = new Point((Width - lblAddress.Width) / 2,
                lblAddress.Height + comboName.Top + 10);
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

            txtCurrentDepartment.Location = new Point((Width - txtCurrentDepartment.Width) / 2,
                txtCurrentDepartment.Height + lblDepartment.Top + 5);
            txtCurrentDepartment.Anchor = AnchorStyles.None;

            lblSelect.Location = new Point((Width - comboDepartment.Width * 2 - 55) / 2,
                lblSelect.Height + txtCurrentDepartment.Top + 10);
            lblSelect.Anchor = AnchorStyles.None;

            comboDepartment.Location = new Point((Width - comboDepartment.Width) / 2,
                comboDepartment.Height + txtCurrentDepartment.Top + 12);
            comboDepartment.Anchor = AnchorStyles.None;

            btnEdit.Location = new Point((Width - btnEdit.Width) / 2,
                btnEdit.Height + comboDepartment.Top + 5);
            btnEdit.Anchor = AnchorStyles.None;
        }

        public void DisplaySelectedEmployee(string[] details)
        {
            txtAddress.Text = details[0];
            txtEmail.Text = details[1];
            txtPassword.Text = details[2];
            txtPhone.Text = details[3];
            txtCurrentDepartment.Text = details[4];
        }

        private void CopyComboBoxValues(ComboBox comboToCopy)
        {
            foreach(var item in comboToCopy.Items)
            {
                ComboName.Items.Add(item);
            }
        }
    }
}
