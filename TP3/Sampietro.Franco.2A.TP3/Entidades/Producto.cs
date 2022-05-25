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

        public double Precio
        {
            get
            {
                if (precio > 0)
                    return precio;
                return 0;
            }
        }

        protected Producto(double precio, int stock, string informacion)
        {
            this.precio = precio;
            this.stock = stock;
            this.informacion = informacion;
        }

        public virtual string mostrarInformacion()
        {
            return "Precio: " + precio + "$ARS" + Environment.NewLine + "Stock: x" + stock + Environment.NewLine + informacion;
        }
        public abstract string mostrarInformacionDetallada();
    }
}
