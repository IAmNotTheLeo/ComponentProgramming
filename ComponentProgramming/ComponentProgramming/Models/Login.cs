using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControlls;

namespace ComponentProgramming.Models
{
    class Login
    {
        private CustomTextBox usernameBox = new CustomTextBox();
        private TextBox passwordBox = new TextBox();
        private CustomLabel usernameLbl = new CustomLabel();
        private CustomLabel passwordLbl = new CustomLabel();
        private CustomButton loginBtn = new CustomButton();

        public CustomTextBox UsernameBox { get => usernameBox; set => usernameBox = value; }
        public TextBox PasswordBox { get => passwordBox; set => passwordBox = value; }
        public CustomLabel UsernameLbl { get => usernameLbl; set => usernameLbl = value; }
        public CustomLabel PasswordLbl { get => passwordLbl; set => passwordLbl = value; }
        public CustomButton LoginBtn { get => loginBtn; set => loginBtn = value; }
    }
}
