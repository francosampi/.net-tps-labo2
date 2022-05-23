using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Heladeria
    {
        public static string nombre;
        public static List<Producto> productos;

        static Heladeria()
        {
            Heladeria.productos = new List<Producto>();  
        }

        public List<Producto> AgregarProducto(Producto producto)
        {
            Heladeria.productos.Add(producto);
            return productos;
        }

        public string MostrarProductos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto producto in productos)
            {
                sb.Append(producto.mostrarInformacion());
            }
            return sb.ToString();
        }
    }
}
