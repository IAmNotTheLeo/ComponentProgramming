namespace ComponentProgramming
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passBox = new Class_Library.CustomTextBox();
            this.usernameBox = new Class_Library.CustomTextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.Color.White;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passBox.Location = new System.Drawing.Point(167, 232);
            this.passBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(133, 23);
            this.passBox.TabIndex = 4;
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.White;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameBox.Location = new System.Drawing.Point(167, 174);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(133, 23);
            this.usernameBox.TabIndex = 5;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(164, 153);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(73, 17);
            this.usernameLbl.TabIndex = 6;
            this.usernameLbl.Text = "Username";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(164, 211);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(69, 17);
            this.passLbl.TabIndex = 7;
            this.passLbl.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(167, 262);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(133, 35);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 563);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Class_Library.CustomTextBox passBox;
        private Class_Library.CustomTextBox usernameBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Button loginBtn;
    }
}

