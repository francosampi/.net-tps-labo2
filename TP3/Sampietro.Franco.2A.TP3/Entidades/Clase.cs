using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clase
    {
        public Profesor profesor;
        public Curso curso;
        public List<Alumno> alumnos;
        public Dias dias;
        public Horario horario;

        public Clase()
        {
        }

        public Clase(Profesor profesor, Curso curso, Dias dias, Horario horario)
        {
            this.profesor = profesor;
            this.curso = curso;
            this.dias = dias;
            this.horario = horario;
            this.alumnos = new List<Alumno>();
        }

        public override string ToString()
        {
            return this.curso.ToString()+" (Turno: "+this.horario.ToString()+")";
        }

        public string Ficha()
        {
            return "Materia dada: " + this.curso.ToString() + Environment.NewLine +
                "Profesor: " + this.profesor.ToString() + Environment.NewLine +
                "Dias: " + this.dias.ToString() + Environment.NewLine +
                "Horario: " + this.horario;
        }

        public string FichaCompleta()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Ficha());
            foreach(Alumno alumno in alumnos)
            {
                sb.Append(alumno.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Agregar alumno a la clase, si es posible
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Clase operator +(Clase c, Alumno a)
        {
            if (c!=a)
            {
                c.alumnos.Add(a);
            }
            return c;
        }

        /// <summary>
        /// Remover alumno de la clase, si es posible
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Clase operator -(Clase c, Alumno a)
        {
            if (c==a)
            {
                c.alumnos.Remove(a);
            }
            return c;
        }

        /// <summary>
        /// Chequear si el alumno se encuentra en la clase
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Clase c, Alumno a)
        {
            foreach (Alumno alumno in c.alumnos)
            {
                if (alumno == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Clase c, Alumno a)
        {
            return !(c == a);
        }
    }
}