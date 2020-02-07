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
        RichTextBox richtxtDetails = new RichTextBox();
        CustomButton btnDelete = new CustomButton();

        public CustomLabel LblName { get => lblName; set => lblName = value; }
        public ComboBox ComboName { get => comboName; set => comboName = value; }
        public RichTextBox RichtxtDetails { get => richtxtDetails; set => richtxtDetails = value; }
        public CustomButton BtnDelete { get => btnDelete; set => btnDelete = value; }
    }
}
