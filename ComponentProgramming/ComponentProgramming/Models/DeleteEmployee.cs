using CustomControlls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentProgramming.Models
{
    class DeleteEmployee
    {
        CustomLabel lblName = new CustomLabel();
        ComboBox comboName = new ComboBox();
        TextBox txtDetails = new TextBox();
        CustomButton btnDelete = new CustomButton();

        public CustomLabel LblName { get => lblName; set => lblName = value; }
        public ComboBox ComboName { get => comboName; set => comboName = value; }
        public TextBox TxtDetails { get => txtDetails; set => txtDetails = value; }
        public CustomButton BtnDelete { get => btnDelete; set => btnDelete = value; }
    }
}
