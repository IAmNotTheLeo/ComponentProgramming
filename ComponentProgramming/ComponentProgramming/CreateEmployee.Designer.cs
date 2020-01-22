namespace ComponentProgramming
{
    partial class CreateEmployee
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
            this.components = new System.ComponentModel.Container();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.customTextBox31 = new Class_Library.CustomTextBox3();
            this.btnCreateAccount = new Class_Library.CustomButton(this.components);
            this.customLabel1 = new Class_Library.CustomLabel(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customLabel3 = new Class_Library.CustomLabel(this.components);
            this.customTextBox21 = new Class_Library.CustomTextBox2(this.components);
            this.lblAddress = new Class_Library.CustomLabel(this.components);
            this.txtboxFullName = new Class_Library.CustomTextBox2(this.components);
            this.lblFullName = new Class_Library.CustomLabel(this.components);
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.customTextBox31);
            this.pnlAdd.Controls.Add(this.btnCreateAccount);
            this.pnlAdd.Controls.Add(this.customLabel1);
            this.pnlAdd.Controls.Add(this.comboBox1);
            this.pnlAdd.Controls.Add(this.customLabel3);
            this.pnlAdd.Controls.Add(this.customTextBox21);
            this.pnlAdd.Controls.Add(this.lblAddress);
            this.pnlAdd.Controls.Add(this.txtboxFullName);
            this.pnlAdd.Controls.Add(this.lblFullName);
            this.pnlAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(450, 450);
            this.pnlAdd.TabIndex = 4;
            // 
            // customTextBox31
            // 
            this.customTextBox31.BackColor = System.Drawing.Color.White;
            this.customTextBox31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customTextBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customTextBox31.Location = new System.Drawing.Point(125, 234);
            this.customTextBox31.Multiline = true;
            this.customTextBox31.Name = "customTextBox31";
            this.customTextBox31.Size = new System.Drawing.Size(200, 21);
            this.customTextBox31.TabIndex = 10;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.btnCreateAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(94)))), ((int)(((byte)(242)))));
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Location = new System.Drawing.Point(163, 348);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(125, 45);
            this.btnCreateAccount.TabIndex = 9;
            this.btnCreateAccount.Text = "Create";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.BackColor = System.Drawing.Color.Transparent;
            this.customLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.customLabel1.Location = new System.Drawing.Point(167, 268);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(117, 24);
            this.customLabel1.TabIndex = 8;
            this.customLabel1.Text = "Department";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.BackColor = System.Drawing.Color.Transparent;
            this.customLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.customLabel3.Location = new System.Drawing.Point(187, 207);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(77, 24);
            this.customLabel3.TabIndex = 5;
            this.customLabel3.Text = "Phone:";
            // 
            // customTextBox21
            // 
            this.customTextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customTextBox21.Location = new System.Drawing.Point(125, 173);
            this.customTextBox21.Multiline = true;
            this.customTextBox21.Name = "customTextBox21";
            this.customTextBox21.Size = new System.Drawing.Size(200, 21);
            this.customTextBox21.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(179, 146);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(93, 24);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // txtboxFullName
            // 
            this.txtboxFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtboxFullName.Location = new System.Drawing.Point(125, 109);
            this.txtboxFullName.Multiline = true;
            this.txtboxFullName.Name = "txtboxFullName";
            this.txtboxFullName.Size = new System.Drawing.Size(200, 21);
            this.txtboxFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(169, 82);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(112, 24);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "Full Name:";
            // 
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.pnlAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateEmployee";
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdd;
        private Class_Library.CustomButton btnCreateAccount;
        private Class_Library.CustomLabel customLabel1;
        private Class_Library.CustomLabel customLabel3;
        private Class_Library.CustomTextBox2 customTextBox21;
        private Class_Library.CustomLabel lblAddress;
        private Class_Library.CustomTextBox2 txtboxFullName;
        private Class_Library.CustomLabel lblFullName;
        private System.Windows.Forms.ComboBox comboBox1;
        private Class_Library.CustomTextBox3 customTextBox31;
    }
}