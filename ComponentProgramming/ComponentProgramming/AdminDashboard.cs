﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentProgramming
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new CreateEmployee();
            frm.Show();
            Hide();
        }
    }
}
