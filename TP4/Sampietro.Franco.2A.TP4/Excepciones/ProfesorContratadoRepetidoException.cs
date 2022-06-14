using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
   public class ProfesorContratadoRepetidoException : Exception
    {
        public ProfesorContratadoRepetidoException()
        {
        }

        public ProfesorContratadoRepetidoException(string mensaje) : base(mensaje)
        {
        }
    }
}
