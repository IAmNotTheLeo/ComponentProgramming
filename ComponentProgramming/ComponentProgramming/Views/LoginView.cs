using ComponentProgramming.Controllers;
using CustomControlls;
using System.Drawing;
using System.Windows.Forms;

namespace ComponentProgramming.Views
{
    class LoginView : Panel
    {
        public void SetUpControlls(CustomTextBox usernameBox,
            CustomLabel passwordLbl,
            CustomLabel usernameLbl, 
            CustomButton loginBtn, 
            CustomTextBox2 passwordBox,
            Form curForm)
        {
            // Set LoginView to be transparent
            BackColor = Color.Transparent;

            // Set LoginView Size
            Size = curForm.Size;
            Dock = DockStyle.Bottom;

            // Set Text of controls
            usernameLbl.Text = "Username:";
            usernameLbl.AutoSize = true;

            passwordLbl.Text = "Password";
            passwordLbl.AutoSize = true;

            loginBtn.Text = "Login";
            loginBtn.Click += (sender, e) => LoginController.ButtonClick(sender, e);

            // Set up password TextBox
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Size = new Size(200, 21);
            passwordBox.Font = new Font("Microsoft Sans Serif", 12);

            // Add LoginView to Form and other controls to LoginView
            curForm.Controls.Add(this);
            Controls.Add(usernameLbl);
            Controls.Add(usernameBox);
            Controls.Add(passwordLbl);
            Controls.Add(passwordBox);
            Controls.Add(loginBtn);

            SetPositions(usernameBox, passwordLbl, usernameLbl, loginBtn, passwordBox);
        }

        private void SetPositions(CustomTextBox usernameBox,
            CustomLabel passwordLbl,
            CustomLabel usernameLbl,
            CustomButton loginBtn,
            TextBox passwordBox)
        {
            usernameLbl.Location = new Point((Width - usernameLbl.Width * 2) / 2, 
                (Height / 2 - usernameLbl.Height) / 2);
            usernameLbl.Anchor = AnchorStyles.None;

            usernameBox.Location = new Point((Width - usernameBox.Width) / 2,
                usernameBox.Height + usernameLbl.Top + 5);
            usernameBox.Anchor = AnchorStyles.None;

            passwordLbl.Location = new Point((Width - passwordLbl.Width * 2) / 2,
                passwordLbl.Height + usernameBox.Top + 5);
            passwordLbl.Anchor = AnchorStyles.None;

            passwordBox.Location = new Point((Width - passwordBox.Width) / 2,
                passwordBox.Height + passwordLbl.Top + 5);
            passwordBox.Anchor = AnchorStyles.None;

            loginBtn.Location = new Point((Width - loginBtn.Width) / 2,
                loginBtn.Height * 3 / 2 + passwordLbl.Top);
            loginBtn.Anchor = AnchorStyles.None;
        }
    }
}
