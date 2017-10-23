using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    class MyButton:Button
    {
        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
