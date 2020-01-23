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
    public partial class CustomLabel : Label
    {
        public CustomLabel()
        {
            InitializeComponent();
            Font = new Font("Source Code Pro Semibold", 14, FontStyle.Bold);
            BackColor = Color.Transparent;
        }

        public CustomLabel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
