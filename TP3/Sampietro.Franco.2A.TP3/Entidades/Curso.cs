using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private string nombre;
        private double precio;
        private Modalidad modalidad;
        private Nivel nivel;

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
            return "\nNombre: " + this.nombre + "\nPrecio: " + this.precio + "\nModalidad: " + this.modalidad.ToString() + "\nNivel: " + this.nivel;
        }
        public override string ToString()
        {
            return this.nombre;
        }
    }
}