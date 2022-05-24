using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class PaletaHelado : Producto, IAptoTacc
    {
        public enum Tamaño { 
            Mediano,
            Grande
        }

        private string sabor;
        private Tamaño tamaño;
        private string aptoTacc="No disponible para celíacos.";

        public string Sabor
        {
            get { return this.sabor; }
        }

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

        public PaletaHelado(string sabor, Tamaño tamaño, double precio, int stock, string informacion)
            : base(precio, stock, informacion)
        {
            this.sabor = sabor;
            this.tamaño = tamaño;
        }

        public override string mostrarInformacion()
        {
            return "'" + sabor + "'\n (" + tamaño.ToString()+")";
        }

        public override string mostrarInformacionDetallada()
        {
           return this.mostrarInformacion()+"\n"+base.ToString()+"\n"+this.aptoTacc;
        }
    }
}
