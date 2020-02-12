using ComponentProgramming.Controllers;
using CustomControlls;
using System.Drawing;
using System.Windows.Forms;

namespace ComponentProgramming.Views
{
    class LoginView : Panel
    {
        private CustomTextBox2 usernameBox = new CustomTextBox2();
        private CustomTextBox2 passwordBox = new CustomTextBox2();
        private CustomLabel usernameLbl = new CustomLabel();
        private CustomLabel passwordLbl = new CustomLabel();
        private CustomButton loginBtn = new CustomButton();

        public CustomTextBox2 UsernameBox { get => usernameBox; set => usernameBox = value; }
        public CustomTextBox2 PasswordBox { get => passwordBox; set => passwordBox = value; }
        public CustomLabel UsernameLbl { get => usernameLbl; set => usernameLbl = value; }
        public CustomLabel PasswordLbl { get => passwordLbl; set => passwordLbl = value; }
        public CustomButton LoginBtn { get => loginBtn; set => loginBtn = value; }
        public void SetUpControlls(Form curForm)
        {

            BackColor = Color.Transparent;

            Size = curForm.Size;
            Dock = DockStyle.Bottom;

            usernameLbl.Text = "Username:";
            usernameLbl.AutoSize = true;

            passwordLbl.Text = "Password";
            passwordLbl.AutoSize = true;
            passwordBox.PasswordChar = '*';

            loginBtn.Text = "Login";

            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Size = new Size(200, 21);
            passwordBox.Font = new Font("Microsoft Sans Serif", 12);

            curForm.Controls.Add(this);
            Controls.Add(usernameLbl);
            Controls.Add(usernameBox);
            Controls.Add(passwordLbl);
            Controls.Add(passwordBox);
            Controls.Add(loginBtn);

            SetPositions();
        }
        private void SetPositions()
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
