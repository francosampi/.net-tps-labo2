using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace HeladeriaForm
{
    public partial class MenuPrincipal : Form
    {
        private Heladeria heladeria;
        private List<Producto> productos;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.heladeria = new Heladeria("Heladería Gustos Finos");

            PaletaHelado ph1 = new PaletaHelado("Mate cocido", PaletaHelado.Tamaño.Mediano, 120, 20, "Revive un clásico gusto argentino con nuestro nuevo sabor");
            PaletaHelado ph2 = new PaletaHelado("Grande de muzza", PaletaHelado.Tamaño.Grande, 200, 20, "Próximamente de Roquefort disponible");
            ph2.AptoTacc = "Disponible para Celíacos";
            PaletaHelado ph3 = new PaletaHelado("Chocolate", PaletaHelado.Tamaño.Mediano, 180, 2, "Un sabor normal a pedido de nuestro público");
            PaletaHelado ph4 = new PaletaHelado("Fernet Branca", PaletaHelado.Tamaño.Mediano, 240, 1, "Disponible solo en mediano para no excederse.");
            ph4.AptoTacc = "Disponible para Celíacos";
            PaletaHelado ph5 = new PaletaHelado("Caramelo media hora", PaletaHelado.Tamaño.Grande, 140, 20, "Selección del personal.");
            PaletaHelado ph6 = new PaletaHelado("Pasa de uva", PaletaHelado.Tamaño.Mediano, 160, 10, "No te gusta en navidad? dale una segunda chance con nosotros!");
            PaletaHelado ph7 = new PaletaHelado("Crema del cielo", PaletaHelado.Tamaño.Mediano, 120, 20, "0% Artificial");
            PaletaHelado ph8 = new PaletaHelado("Café negro", PaletaHelado.Tamaño.Mediano, 240, 4, "Para desvelarse estudiando.");
            ph8.AptoTacc = "Disponible para Celíacos";

            heladeria += ph1;
            heladeria += ph2;
            heladeria += ph3;
            heladeria += ph4;
            heladeria += ph5;
            heladeria += ph6;
            heladeria += ph7;
            heladeria += ph8;
            //---REPETIDOS---
            heladeria += ph1;
            heladeria += ph8;
            //---------------

            this.productos = (List<Producto>)this.heladeria;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = this.heladeria.nombre;

            foreach (Producto p in this.productos)
            {
                this.lbProductos.Items.Add(p.mostrarInformacion());
            }
        }
    }
}
