using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Library
{
    public partial class CustomButton : Button
    {
        public CustomButton()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(65, 94, 242);
            Width = 125;
            Height = 45;
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = Color.FromArgb(65, 94, 242);
        }

        public CustomButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.FromArgb(65, 94, 242);
            FlatAppearance.BorderColor = Color.FromArgb(65, 94, 242);

        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = Color.Blue;
            FlatAppearance.BorderColor = Color.Blue;

        }
    }
}
