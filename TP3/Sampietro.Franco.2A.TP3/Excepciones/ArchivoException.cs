using System;

namespace Excepciones
{
    public class ArchivoException : Exception
    {
        public ArchivoException()
        {
        }

        public ArchivoException(string mensaje) : base(mensaje)
        {
        }
    }
}