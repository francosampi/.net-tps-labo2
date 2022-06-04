using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoInscriptoRepetidoException : Exception
    {
        public AlumnoInscriptoRepetidoException()
        {
        }

        public AlumnoInscriptoRepetidoException(string mensaje) : base(mensaje)
        {
        }
    }
}