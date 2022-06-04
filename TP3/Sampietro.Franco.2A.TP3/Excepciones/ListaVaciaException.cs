using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ListaVaciaException : Exception
    {
        public ListaVaciaException()
        {
        }

        public ListaVaciaException(string mensaje) : base(mensaje)
        {
        }
    }
}