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
        public static bool soloDigitosEnCelda(this DataGridViewRow row, int columnIndex)
        {
            foreach (char c in Convert.ToString(row.Cells[columnIndex].Value))
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
