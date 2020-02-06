using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControlls;

namespace ComponentProgramming.Views
{
    class DeleteEmployeeView : Panel
    {
        public void SetUpControlls(CustomLabel lblName, 
            ComboBox comboName, 
            TextBox txtDetails, 
            CustomButton btnDelete, Form CurForm)
        {
            BackColor = Color.LightGray;
            Size = CurForm.Size;
            Dock = DockStyle.Bottom;

            


        }
    }
}
