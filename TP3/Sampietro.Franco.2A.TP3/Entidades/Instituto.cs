using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Instituto
    {
        private string nombre;
        public List<Clase> clases;

        public Instituto()
        {
        }

        public Instituto(string nombre)
        {
            this.nombre = nombre;
            this.clases = new List<Clase>();
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

        public static bool operator !=(Instituto i, Clase c)
        {
            return !(i == c);
        }

        public override string ToString()
        {
            return this.nombre;
        }
    }
}
