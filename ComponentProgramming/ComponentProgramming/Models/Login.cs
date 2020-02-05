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
    }
}
