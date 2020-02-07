using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControlls;

namespace ComponentProgramming.Models
{
    class AdminDashboard
    {
        CustomButton btnViewAddEmployee = new CustomButton();
        CustomButton btnViewEditEmployee = new CustomButton();
        CustomButton btnViewDeleteEmployee = new CustomButton();

        public CustomButton BtnViewAddEmployee { get => btnViewAddEmployee; set => btnViewAddEmployee = value; }
        public CustomButton BtnViewEditEmployee { get => btnViewEditEmployee; set => btnViewEditEmployee = value; }
        public CustomButton BtnViewDeleteEmployee { get => btnViewDeleteEmployee; set => btnViewDeleteEmployee = value; }
    }
}
