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
    class AdminDashboardView : Panel
    {
        CustomButton btnViewAddEmployee = new CustomButton();
        CustomButton btnViewEditEmployee = new CustomButton();
        CustomButton btnViewDeleteEmployee = new CustomButton();

        public CustomButton BtnViewAddEmployee { get => btnViewAddEmployee; set => btnViewAddEmployee = value; }
        public CustomButton BtnViewEditEmployee { get => btnViewEditEmployee; set => btnViewEditEmployee = value; }
        public CustomButton BtnViewDeleteEmployee { get => btnViewDeleteEmployee; set => btnViewDeleteEmployee = value; }
        public void SetUpControlls(CustomButton btnViewAddEmployee, 
            CustomButton btnViewEditEmployee, 
            CustomButton btnViewDeleteEmployee, Form curForm)
        {
            BackColor = Color.LightGray;
            Size = curForm.Size;
            Dock = DockStyle.Bottom;

            btnViewAddEmployee.Text = "Add Employee";
            btnViewEditEmployee.Text = "Edit Employee";
            btnViewDeleteEmployee.Text = "Delete Employee";

            curForm.Controls.Add(this);
            Controls.Add(btnViewAddEmployee);
            Controls.Add(btnViewEditEmployee);
            Controls.Add(btnViewDeleteEmployee);

            SetPositions(btnViewAddEmployee, btnViewEditEmployee, btnViewDeleteEmployee);

        }

        public void SetPositions(CustomButton btnViewAddEmployee, CustomButton btnViewEditEmployee, CustomButton btnViewDeleteEmployee)
        {
            btnViewAddEmployee.Location = new Point((Width - btnViewAddEmployee.Width) / 2,
                Height / 5 - btnViewAddEmployee.Height / 2 + 60);
            btnViewAddEmployee.Anchor = AnchorStyles.None;

            btnViewEditEmployee.Location = new Point((Width - btnViewEditEmployee.Width) / 2,
                btnViewEditEmployee.Height + btnViewAddEmployee.Top + 20);
            btnViewEditEmployee.Anchor = AnchorStyles.None;

            btnViewDeleteEmployee.Location = new Point((Width - btnViewDeleteEmployee.Width) / 2,
               btnViewDeleteEmployee.Height + btnViewEditEmployee.Top + 20);
            btnViewDeleteEmployee.Anchor = AnchorStyles.None;
        }
    }
}
