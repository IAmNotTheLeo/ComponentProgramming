using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControlls;

namespace ComponentProgramming.Views
{
    class DeleteEmployeeView : Panel
    {
        public void SetUpControlls(CustomLabel lblName, 
            ComboBox comboName, 
            RichTextBox richtxtDetails, 
            CustomButton btnDelete, Form curForm)
        {
            BackColor = Color.LightGray;
            Size = curForm.Size;
            Dock = DockStyle.Bottom;

            lblName.Text = "Employee Name";
            lblName.AutoSize = true;
            comboName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboName.DropDownHeight = 200;
            comboName.Font = new Font("Microsoft Sans Serif", 10);


            richtxtDetails.Multiline = true;
            richtxtDetails.Size = new Size(200, 275);
            richtxtDetails.Enabled = false;
            richtxtDetails.Font = new Font("Microsoft Sans Serif", 11);

            btnDelete.Text = "Delete Employee";

            curForm.Controls.Add(this);
            Controls.Add(lblName);
            Controls.Add(comboName);

            Controls.Add(richtxtDetails);

            Controls.Add(btnDelete);

            SetPositions(lblName, comboName, richtxtDetails, btnDelete);
        }

        private void SetPositions(CustomLabel lblName,
            ComboBox comboName,
            RichTextBox richtxtDetails,
            CustomButton btnDelete)
        {
            lblName.Location = new Point((Width - lblName.Width) / 2,
                Height / 5 - lblName.Height / 2 - 60);
            lblName.Anchor = AnchorStyles.None;

            comboName.Location = new Point((Width - comboName.Width) / 2,
                comboName.Height + lblName.Top + 12);
            comboName.Anchor = AnchorStyles.None;

            richtxtDetails.Location = new Point((Width - richtxtDetails.Width) / 2,
                richtxtDetails.Height + comboName.Top - 235);
            richtxtDetails.Anchor = AnchorStyles.None;

            btnDelete.Location = new Point((Width - btnDelete.Width) / 2,
                btnDelete.Height + richtxtDetails.Top + 250);
            btnDelete.Anchor = AnchorStyles.None;
        }
    }
}
