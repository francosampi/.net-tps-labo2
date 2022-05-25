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
using PaletaForm;

namespace HeladeriaForm
{
    public partial class MenuPrincipal : Form
    {
        private Heladeria heladeria;
        private List<Producto> productos;
        private Producto productoSeleccionado;
        private double precio;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.heladeria = new Heladeria("Heladería Gustos Finos");

            PaletaHelado ph1 = new PaletaHelado("Mate amargo", 120, 20, "Revive un clásico gusto argentino con nuestro nuevo sabor");
            PaletaHelado ph2 = new PaletaHelado("Grande de muzza", 200, 20, "Próximamente sabor 4 quesos disponible");
            ph2.AptoTacc = "Sin TACC";
            PaletaHelado ph3 = new PaletaHelado("Nata y Chocolate", 100, 2, "Abundante y en oferta.");
            PaletaHelado ph4 = new PaletaHelado("Fernet Branca", 240, 1, "Disponible solo en mediano para no excederse.");
            ph4.AptoTacc = "Sin TACC";
            PaletaHelado ph5 = new PaletaHelado("Caramelo media hora", 140, 20, "Selección del personal.");
            PaletaHelado ph6 = new PaletaHelado("Pasas de uva", 160, 10, "No te gusta en navidad? dale una segunda chance con nosotros!");
            PaletaHelado ph7 = new PaletaHelado("Kinotos del cielo", 120, 20, "0% Artificial");
            PaletaHelado ph8 = new PaletaHelado("Café negro", 240, 4, "Para desvelarse estudiando.");
            ph8.AptoTacc = "Sin TACC";
            PaletaHelado ph9 = new PaletaHelado("Limón con menta", 120, 999, "El favorito del dueño.");
            ph9.AptoTacc = "Sin TACC";
            PaletaHelado ph10 = new PaletaHelado("Chicle (El Pitufo)", 80, 20, "Azul como el mar azul.");
            PaletaHelado ph11 = new PaletaHelado("Ceviche peruano", 320, 20, "Delicioso.");

            this.heladeria += ph1;
            this.heladeria += ph2;
            this.heladeria += ph3;
            this.heladeria += ph4;
            this.heladeria += ph5;
            this.heladeria += ph6;
            this.heladeria += ph7;
            this.heladeria += ph8;
            this.heladeria += ph9;
            this.heladeria += ph10;
            this.heladeria += ph11;
            //---REPETIDOS---
            this.heladeria += ph1;
            this.heladeria += ph8;
            //---------------

            this.productos = (List<Producto>)this.heladeria;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Text = this.heladeria.nombre;
            this.lblPrecio.Text = "0$ARS";

            this.lbProductos.DataSource = this.productos;
        }

        private void lbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.productoSeleccionado = ((Producto)this.lbProductos.SelectedItem);
                string paleta = productoSeleccionado.mostrarInformacionDetallada();

                this.txtbInformacion.Text = paleta;
            }
            catch (NullReferenceException ex)
            {
                this.txtbInformacion.Text = ex.Message;
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            MenuEspecificaciones especificacionesForm = new MenuEspecificaciones(productoSeleccionado.Precio);
            DialogResult resultado = especificacionesForm.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.lbCarrito.Items.Add(this.productoSeleccionado.mostrarInformacion());
                this.precio += especificacionesForm.precioTotal;
                this.lblPrecio.Text = this.precio.ToString() + "$ARS";
                pbarPedido.Value = 33;
                lblPorcentajePedido.Text = "33%";
            }
        }
    }
}
