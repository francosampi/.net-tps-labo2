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
            return "Nombre: " + this.nombre +Environment.NewLine+ "Mail: " + this.mail +Environment.NewLine + "Total abonado: " + this.totalAbonado + " (" + this.tipoDePago.ToString() + ")" + Environment.NewLine + "Nacionalidad: " + this.nacionalidad;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
