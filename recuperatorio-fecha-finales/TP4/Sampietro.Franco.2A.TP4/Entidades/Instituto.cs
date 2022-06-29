using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Instituto
    {
        public string nombre;
        public List<Profesor> profesores;
        public List<Alumno> alumnos;
        public List<Curso> cursos;
        public List<Clase> clases;

        public Instituto()
        {
        }

        public Instituto(string nombre)
        {
            this.nombre = nombre;
            this.profesores = new List<Profesor>();
            this.alumnos = new List<Alumno>();
            this.cursos = new List<Curso>();
            this.clases = new List<Clase>();
        }

        /// <summary>
        /// Agregar alumno al Instituto, si es posible
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Instituto operator +(Instituto i, Alumno a)
        {
            if (i != a)
            {
                i.alumnos.Add(a);
            }
            else
            {
                throw new AlumnoInscriptoRepetidoException();
            }
            return i;
        }

        /// <summary>
        /// Remover alumno del Instituto, si es posible
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Instituto operator -(Instituto i, Alumno a)
        {
            if (i == a)
            {
                i.alumnos.Remove(a);
            }
            return i;
        }

        /// <summary>
        /// Chequear si el alumno se encuentra en el instituto
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Instituto i, Alumno a)
        {
            foreach (Alumno alumno in i.alumnos)
            {
                if (alumno == a)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Chequear si el alumno no se encuentra en el instituto
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Instituto i, Alumno a)
        {
            return !(i == a);
        }

        /// <summary>
        /// Agregar profesor al Instituto, si es posible
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Instituto operator +(Instituto i, Profesor p)
        {
            if (i != p)
            {
                i.profesores.Add(p);
            }
            else
            {
                throw new ProfesorContratadoRepetidoException();
            }
            return i;
        }

        /// <summary>
        /// Remover profesor del Instituto, si es posible
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Instituto operator -(Instituto i, Profesor p)
        {
            if (i == p)
            {
                i.profesores.Remove(p);
            }
            return i;
        }

        /// <summary>
        /// Chequear si el profesor se encuentra en el instituto
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Instituto i, Profesor p)
        {
            foreach (Profesor profesor in i.profesores)
            {
                if (profesor == p)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Chequear si el profesor no se encuentra en el instituto
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Instituto i, Profesor p)
        {
            return !(i == p);
        }

        public override string ToString()
        {
            return this.nombre;
        }

        /// <summary>
        /// Agregar clase al Instituto, si es posible
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Instituto operator +(Instituto i, Clase c)
        {
            if (i != c)
            {
                i.clases.Add(c);
            }
            else
            {
                throw new ClaseRepetidaException();
            }
            return i;
        }

        /// <summary>
        /// Remover clase del Instituto, si es posible
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Instituto operator -(Instituto i, Clase c)
        {
            if (i == c)
            {
                i.clases.Remove(c);
            }
            return i;
        }

        /// <summary>
        /// Chequear si la clase se encuentra en el instituto
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Instituto i, Clase c)
        {
            foreach (Clase clase in i.clases)
            {
                if (clase == c)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Chequear si la clase no se encuentra en el instituto
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Instituto i, Clase c)
        {
            return !(i == c);
        }
    }
}
