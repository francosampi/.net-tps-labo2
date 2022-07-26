using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public static class MetodosExtension
    {
        public static bool soloDigitosEnTextBox(this TextBox tb)
        {
            foreach (char c in Convert.ToString(tb.Text))
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
