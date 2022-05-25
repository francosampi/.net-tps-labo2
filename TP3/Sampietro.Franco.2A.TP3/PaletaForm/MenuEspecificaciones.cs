using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletaForm
{
    public partial class MenuEspecificaciones : Form
    {
        public double precioPaleta;
        public double precioTotal;
        public ETamaño tamaño; 


        public MenuEspecificaciones()
        {
            InitializeComponent();
        }

        public MenuEspecificaciones(double precio) : this()
        {
            this.precioPaleta = precio;
            this.precioTotal = precioPaleta;
            this.tamaño = ETamaño.Mediano;
        }

        private void MenuEspecificaciones_Load(object sender, EventArgs e)
        {
            lblPrecio.Text = precioTotal.ToString() + "$ARS";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rbMediano_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMediano.Checked)
            {
                precioTotal = precioPaleta;
                lblPrecio.Text = precioTotal.ToString() + "$ARS";
                this.tamaño = ETamaño.Mediano;
            }
        }

        private void rbGrande_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGrande.Checked)
            {
                precioTotal = precioPaleta+40;
                lblPrecio.Text = precioTotal.ToString()+"$ARS";
                this.tamaño = ETamaño.Grande;
            }
        }
    }
}
