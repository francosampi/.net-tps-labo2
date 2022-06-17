using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class Delegados
    {
        public delegate void delegadoDetalles(object entidad, TextBox tb, Func<string> recibirDeFicha);
    }
}
