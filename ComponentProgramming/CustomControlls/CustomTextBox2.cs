using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlls
{
    public partial class CustomTextBox2 : TextBox
    {
        public CustomTextBox2()
        {
            InitializeComponent();
            BorderStyle = BorderStyle.None;
            Multiline = true;
            Font = new Font("Microsoft Sans Serif", 12);
            Size = new Size(200, 21);
        }

        public CustomTextBox2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
