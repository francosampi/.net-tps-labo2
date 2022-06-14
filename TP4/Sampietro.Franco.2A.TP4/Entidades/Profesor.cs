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
        public Curso curso;

        public Profesor()
        {
        }

        public Profesor(string nombre, string mail, Curso curso)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.curso = curso;
        }

        public string Ficha()
        {
            return "\nNombre: "+this.nombre+Environment.NewLine+"Mail: "+this.mail+Environment.NewLine+"Curso que da: "+this.curso;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public static bool operator ==(Profesor p1, Profesor p2)
        {
            return (p1.nombre == p2.nombre && p1.mail == p2.mail);
        }

        public static bool operator !=(Profesor p1, Profesor p2)
        {
            return !(p1 == p2);
        }
    }
}