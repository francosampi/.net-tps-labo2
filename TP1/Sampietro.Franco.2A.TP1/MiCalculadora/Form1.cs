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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();

            cmbOperador.Items.Add("");
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");
        }

        /// <summary>
        /// Se borran las cajas de texto correspondiente a los numeros, al label del resultado y el operador pasa a estar vacio
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lblResultado.Text = "";
            cmbOperador.SelectedIndex = 0;
            lstOperaciones.Items.Clear();
        }

        private void reemplazarTextoVacio(TextBox textbox)
        {
            textbox.Text = textbox.Text.Replace('.', ',');
            textbox.Text = textbox.Text.Trim();

            if (String.IsNullOrEmpty(textbox.Text))
            {
                textbox.Text = "0";
            }
        }

        /// <summary>
        /// Lanza una ventana emergente preguntando si desea salir o no, valido para apretar ctrl+Z, cerrar desde barra superior, o con el boton de cerrar
        /// </summary>
        /// <returns>false si cancela, true si se cierra</returns>
        private bool ConfirmarSalir()
        {
            DialogResult res = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res != DialogResult.Yes)
            {
                return false;
            }
            return true;
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (this.ConfirmarSalir())
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Rescatar el motivo de cierre y confirmar si se desea salir de la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!this.ConfirmarSalir())
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            string resultado;

            reemplazarTextoVacio(txtNumero1);
            reemplazarTextoVacio(txtNumero2);

            Operando n1 = new Operando(txtNumero1.Text);
            Operando n2 = new Operando(txtNumero2.Text);

            if (cmbOperador.SelectedIndex == 0)
            {
                cmbOperador.SelectedIndex = 1;
            }

            if (char.TryParse(cmbOperador.Text, out operador))
            {
                resultado = Calculadora.Operar(n1, n2, operador).ToString();
                StringBuilder sb = new StringBuilder();

                lblResultado.Text = resultado;
                
                sb.Append(n1.Numero + operador + n2.Numero + " = " + resultado);

                lstOperaciones.Items.Insert(0, sb.ToString());
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando res = new Operando(lblResultado.Text);

            lblResultado.Text = res.BinarioDecimal(res.Numero);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando res = new Operando(lblResultado.Text);

            lblResultado.Text = res.DecimalBinario(res.Numero);
        }
    }
}