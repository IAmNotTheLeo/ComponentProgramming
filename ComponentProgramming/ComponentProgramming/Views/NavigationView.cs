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
    class NavigationView : Panel
    {
        private CustomButton goBack = new CustomButton();
        private CustomButton logoutBtn = new CustomButton();

        public CustomButton LogoutBtn { get => logoutBtn; set => logoutBtn = value; }
        public CustomButton GoBack { get => goBack; set => goBack = value; }

        public void SetUpControlls(Form curForm)
        {
            BackColor = Color.Gray;
            Location = new Point(0, 0);
            Anchor = AnchorStyles.None;
            Size = new Size(100, 60);
            Dock = DockStyle.Bottom;

            goBack.Text = "Go Back";
            logoutBtn.Text = "Logout";

            curForm.Controls.Add(this);
            Controls.Add(goBack);
            Controls.Add(logoutBtn);

            SetPositions();
        }

        private void SetPositions()
        {
            goBack.Location = new Point(30, 5);
            goBack.Anchor = AnchorStyles.None;

            logoutBtn.Location = new Point(goBack.Left + logoutBtn.Width + 10, 5);
            logoutBtn.Anchor = AnchorStyles.None;
        }
    }
}
