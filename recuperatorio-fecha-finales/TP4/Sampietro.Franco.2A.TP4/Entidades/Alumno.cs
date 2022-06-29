using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        public string nombre;
        public string mail;
        public double totalAbonado;
        public Curso curso;
        public Nacionalidad nacionalidad;
        public TipoDePago tipoDePago;

        public Alumno()
        {
        }

        public Alumno(string nombre, string mail, double totalAbonado, Nacionalidad nacionalidad, TipoDePago tipoDePago)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.totalAbonado = totalAbonado;
            this.nacionalidad = nacionalidad;
            this.tipoDePago = tipoDePago;
        }

        public string Ficha()
        {
            return "Nombre: " + this.nombre + Environment.NewLine + "Mail: " + this.mail +
                Environment.NewLine + "Nacionalidad: " + this.nacionalidad +
                Environment.NewLine + "Curso que da: " + this.curso +
                Environment.NewLine + "Total abonado: " + this.totalAbonado + " (" + this.tipoDePago.ToString() + ")";
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return (a1.nombre == a2.nombre && a1.mail == a2.mail && a1.nacionalidad == a2.nacionalidad);
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }
    }
}
