using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ClaseRepetidaException : Exception
    {
        public ClaseRepetidaException()
        {
        }

        public ClaseRepetidaException(string mensaje) : base(mensaje)
        {
        }
    }
}
