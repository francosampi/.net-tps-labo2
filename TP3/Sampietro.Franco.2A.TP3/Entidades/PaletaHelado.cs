using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class PaletaHelado : Producto
    {
        public enum Tamaño { 
            Mediano,
            Grande
        }

        private string sabor;
        private Tamaño tamaño;

        public string Sabor
        {
            get { return this.sabor; }
        }

        public PaletaHelado(string sabor, Tamaño tamaño, double precio, int stock, string informacion)
            : base(precio, stock, informacion)
        {
            this.sabor = sabor;
            this.tamaño = tamaño;
        }

        public override string mostrarInformacion()
        {
            return "Paleta sabor: " + sabor + "\nTamaño" + tamaño;
        }

        public override string mostrarInformacionDetallada()
        {
           return this.mostrarInformacion()+"\n"+base.ToString();
        }
    }
}
