using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        private double precio;
        private int stock;
        private string informacion;

        protected Producto(double precio, int stock, string informacion)
        {
            this.precio = precio;
            this.stock = stock;
            this.informacion = informacion;
        } 

        public virtual string mostrarInformacion()
        {
            return "\n----------\nPrecio: " + precio + "\nStock: x" + stock + "\n" + informacion + "\n----------\n";
        }
        public abstract string mostrarInformacionDetallada();
    }
}
