using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        public string nombre;
        public double precio;
        public Modalidad modalidad;
        public Nivel nivel;

        public Curso()
        {
        }

        public Curso(string nombre, double precio, Modalidad modalidad, Nivel nivel)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.modalidad = modalidad;
            this.nivel = nivel;
        }

        /// <summary>
        /// Mostrar informacion del curso
        /// </summary>
        /// <returns></returns>
        public string Ficha()
        {
            return "Nombre: " + Environment.NewLine + this.nombre + 
                Environment.NewLine + "Precio: " + this.precio + 
                Environment.NewLine + "Modalidad: " + this.modalidad.ToString() + 
                Environment.NewLine + "Nivel: " + this.nivel;
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}