using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor
    {
        private string nombre;
        private string mail;
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
            return "\nNombre: "+this.nombre+"\nMail:"+this.mail;
        }

        public override string ToString()
        {
            return Environment.NewLine + "Nombre: " + this.nombre + Environment.NewLine + "Mail:" + this.mail;
        }
    }
}