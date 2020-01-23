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
        private Label usernameLbl = new Label();
        private Label passwordLbl = new Label();
        private CustomButton loginBtn = new CustomButton();

        public CustomTextBox UsernameBox { get => usernameBox; set => usernameBox = value; }
        public TextBox PasswordBox { get => passwordBox; set => passwordBox = value; }
        public Label UsernameLbl { get => usernameLbl; set => usernameLbl = value; }
        public Label PasswordLbl { get => passwordLbl; set => passwordLbl = value; }
        public CustomButton LoginBtn { get => loginBtn; set => loginBtn = value; }
    }
}
