using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Library
{
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();
            BorderStyle = BorderStyle.None;
            Font = new Font(Font.FontFamily, 12);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
           
            if(!Regex.IsMatch(Text, @"^\d+$") && Text.Length > 0)
            {
                BackColor = Color.FromArgb(240, 128, 128);
                
            }
            else
            {
                BackColor = Color.White;
            }
        }
    }
}
