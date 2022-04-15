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
        /// <summary>
        /// Iniciar aplicación, agregar opciones de operadores al combo box.
        /// </summary>
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

        /// <summary>
        /// Tomar la informacion de una caja de texto y borrarla. Reemplazar puntos por comas en los números.
        /// </summary>
        /// <param name="textbox"></param>
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
        /// Aplicar conversion de decimal a binario o viceversa dependiendo el entero recibido (0 o 1) y si el label resultado no está vacío
        /// En caso de no ser un valor invalido, agregarlo a la lista
        /// </summary>
        /// <param name="operacion"></param>
        private void aplicarConversion(int operacion)
        {
            if (!String.IsNullOrEmpty(lblResultado.Text))
            {
                Operando res = new Operando();

                lblResultado.Text = operacion == 0 ? res.BinarioDecimal(lblResultado.Text) : res.DecimalBinario(lblResultado.Text);

                if (lblResultado.Text!="Valor inválido")
                {
                    lstOperaciones.Items.Insert(0, lblResultado.Text);
                }
            }
        }

        /// <summary>
        /// Lanza una ventana emergente preguntando si desea salir o no, valido para apretar ctrl+Z, cerrar desde barra superior, o con el boton de cerrar
        /// </summary>
        /// <returns>false si cancela, true si se cierra</returns>
        private bool ventanaConfirmarSalir()
        {
            DialogResult res = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (res != DialogResult.Yes)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Aplicar limpieza de la informacion al iniciar la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Limpiar toda la informacion impresa en pantalla, cajas de texto, lista de resultados, label del resultado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Confirmar motivo de cierre y cerrar la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (this.ventanaConfirmarSalir())
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
                if (!this.ventanaConfirmarSalir())
                {
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Se limpian los espacios en blanco de las cajas de texto, se aplica el operador suma si no tiene ninguno
        /// Se realiza la operacion y la imprime en el label de arriba, en caso de no ser division por cero, sino se emite un mensaje de error
        /// Luego de imprimir en el label de arriba, se guarda el resultado en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            double resultado;

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
                resultado = Calculadora.Operar(n1, n2, operador);

                if(resultado!=double.MinValue)
                {
                    StringBuilder sb = new StringBuilder();

                    lblResultado.Text = resultado.ToString();

                    sb.Append(txtNumero1.Text + " " + operador + " " + txtNumero2.Text + " = " + resultado);

                    lstOperaciones.Items.Insert(0, sb.ToString());
                }
                else
                {
                    MessageBox.Show("Error! No se puede dividir por 0.", "Error matemático", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblResultado.Text = "Valor inválido";
                }
            }
        }

        /// <summary>
        /// Convierte el resultado del label en Binario si es posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            aplicarConversion(1);
        }

        /// <summary>
        /// Convierte el resultado del label en Decimal si es un resultado convertido en Binario previamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            aplicarConversion(0);
        }
    }
}