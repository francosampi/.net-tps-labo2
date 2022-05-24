using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Heladeria
    {
        public string nombre;
        public List<Producto> productos;

        public Heladeria(string nombre)
        {
            this.productos = new List<Producto>();
            this.nombre = nombre;
        }

        private string MostrarProductos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto producto in productos)
            {
                sb.Append(producto.mostrarInformacion());
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarProductos();
        }

        public static explicit operator List<Producto>(Heladeria h)
        {
            return h.productos;
        }

        public static Heladeria operator +(Heladeria h, Producto p)
        {
            if(!(h is null) && !(p is null))
            {
                if (h!=p)
                {
                    h.productos.Add(p);
                }     
            }
            return h;
        }

        public static bool operator ==(Heladeria h, Producto p)
        {
            if (!(h is null) && !(p is null))
            {
                foreach(Producto producto in h.productos)
                {
                    if (producto.Equals(p))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Heladeria h, Producto p)
        {
            return !(h == p);
        }
    }
}
