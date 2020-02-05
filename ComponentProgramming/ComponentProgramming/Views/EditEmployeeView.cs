using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CustomControlls;
using System.Windows.Forms;

namespace ComponentProgramming.Views
{
    class EditEmployeeView : Panel
    {
        public void SetUpControlls(CustomLabel lblName,
            CustomLabel lblAddress,
            CustomLabel lblEmail,
            CustomLabel lblPassword,
            CustomLabel lblPhone,
            CustomLabel lblDepartment,
            ComboBox comboName,
            CustomTextBox2 txtAddress,
            CustomTextBox2 txtEmail,
            CustomTextBox2 txtPassword,
            CustomTextBox3 txtPhone,
            ComboBox comboDepartment,
            CustomButton btnEdit,
            Form curform)
        {
            BackColor = Color.LightGray;
            Size = curform.Size;
            Dock = DockStyle.Bottom;

            lblName.Text = "Employee Name";
            lblName.AutoSize = true;

            lblAddress.Text = "Address:";
            lblAddress.AutoSize = true;

            lblEmail.Text = "Email Address:";
            lblEmail.AutoSize = true;

            lblPassword.Text = "Password:";
            lblPassword.AutoSize = true;

            lblPhone.Text = "Phone:";
            lblPhone.AutoSize = true;

            lblDepartment.Text = "Department:";
            lblDepartment.AutoSize = true;
            comboDepartment.Font = new Font("Microsoft Sans Serif", 12);

            btnEdit.Text = "Edit Account";

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
            Controls.Add(comboDepartment);

            Controls.Add(btnEdit);

            SetPositions(lblName, lblAddress, lblEmail, lblPassword, lblPhone, lblDepartment, comboName, txtAddress, txtEmail, txtPassword, txtPhone, comboDepartment, btnEdit);
        }

        private void SetPositions(CustomLabel lblName, 
            CustomLabel lblAddress, 
            CustomLabel lblEmail, 
            CustomLabel lblPassword, 
            CustomLabel lblPhone, 
            CustomLabel lblDepartment, 
            ComboBox comboName, 
            CustomTextBox2 txtAddress, 
            CustomTextBox2 txtEmail, 
            CustomTextBox2 txtPassword, 
            CustomTextBox3 txtPhone, 
            ComboBox comboDepartment,
            CustomButton btnEdit)
        {
            lblName.Location = new Point((Width - lblName.Width) / 2,
                Height / 5 - lblName.Height / 2 - 60);
            lblName.Anchor = AnchorStyles.None;

            comboName.Location = new Point((Width - comboName.Width) / 2,
                comboName.Height + lblName.Top + 12);
            comboName.Anchor = AnchorStyles.None;

            lblAddress.Location = new Point((Width - lblAddress.Width * 2 - 17) / 2,
                lblAddress.Height + comboName.Top + 10);
            lblAddress.Anchor = AnchorStyles.None;

            txtAddress.Location = new Point((Width - txtAddress.Width) / 2,
                txtAddress.Height + lblAddress.Top + 5);
            txtAddress.Anchor = AnchorStyles.None;

            lblEmail.Location = new Point((Width - lblEmail.Width * 1 - 60) / 2,
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

            comboDepartment.Location = new Point((Width - comboDepartment.Width) / 2,
                comboDepartment.Height + lblDepartment.Top + 5);
            comboDepartment.Anchor = AnchorStyles.None;

            btnEdit.Location = new Point((Width - btnEdit.Width) / 2,
                btnEdit.Height + comboDepartment.Top + 10);
            btnEdit.Anchor = AnchorStyles.None;
        }
    }
}
