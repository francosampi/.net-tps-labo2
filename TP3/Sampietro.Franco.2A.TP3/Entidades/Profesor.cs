using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor
    {
        public string nombre;
        public string mail;
        public List<Clase> clases;

        public Profesor()
        {
        }

        public Profesor(string nombre, string mail)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.clases = new List<Clase>();
        }

        public string Ficha()
        {
            return "\nNombre: "+this.nombre+Environment.NewLine+"Mail:"+this.mail;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}