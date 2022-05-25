using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class PaletaHelado : Producto, IAptoTacc
    {
        private string sabor;
        private string aptoTacc;

        public string AptoTacc
        {
            get
            {
                return this.aptoTacc;
            }
            set
            {
                this.aptoTacc = value;
            }
        }

        public ETamaño Tamaño
        {
            get; set;
        }

        public PaletaHelado(string sabor, double precio, int stock, string informacion)
            : base(precio, stock, informacion)
        {
            this.sabor = sabor;
            this.Tamaño = ETamaño.Mediano;
            this.AptoTacc = "";
        }

        public override string mostrarInformacion()
        {
            return "'" + sabor + "'";
        }

        public override string mostrarInformacionDetallada()
        {
           return base.mostrarInformacion()+ Environment.NewLine + Environment.NewLine + this.aptoTacc;
        }

        public override string ToString()
        {
            return mostrarInformacion();
        }

        public override bool Equals(object obj)
        {
            return obj is PaletaHelado ph && this == ph;
        }
    }
}
