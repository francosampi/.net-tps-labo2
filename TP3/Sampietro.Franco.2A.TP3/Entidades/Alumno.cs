using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string nombre;
        private string mail;
        private double totalAbonado;
        public List<Curso> cursos;
        private Nacionalidad nacionalidad;
        private TipoDePago tipoDePago;

        public Alumno()
        {
        }

        public Alumno(string nombre, string mail, Nacionalidad nacionalidad, TipoDePago tipoDePago)
        {
            this.nombre = nombre;
            this.mail = mail;
            this.nacionalidad = nacionalidad;
            this.tipoDePago = tipoDePago;
            this.cursos = new List<Curso>();
        }

        public string Ficha()
        {
            return "\nNombre: " + this.nombre + "\nMail: " + this.mail + "\nTotal abonado: " + this.totalAbonado + " (" + this.tipoDePago.ToString() + ")\nNacionalidad: " + this.nacionalidad;
        }

        public override string ToString()
        {
            return "Nombre: " + this.nombre + Environment.NewLine +
                "Mail: " + this.mail + Environment.NewLine +
                "Total abonado: " + this.totalAbonado + " (" + this.tipoDePago.ToString() + ")"+ Environment.NewLine +
                "Nacionalidad: " + this.nacionalidad;
        }
    }
}
