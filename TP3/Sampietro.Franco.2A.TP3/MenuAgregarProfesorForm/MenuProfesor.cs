using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MenuAgregarProfesorForm
{
    public partial class frmMenuProfesor : Form
    {
        Profesor profesor;
        FormAccion formAccion;
        private bool nombreValidado = false;
        private bool mailValidado = false;
        Color colorDefault = SystemColors.Window;
        Color colorError = Color.Red;

        public frmMenuProfesor()
        {
            InitializeComponent();
        }

        public frmMenuProfesor(Profesor profesor, FormAccion formAccion) : this()
        {
            this.profesor = profesor;
            this.formAccion = formAccion;
        }

        private void frmMenuProfesor_Load(object sender, EventArgs e)
        {
            if (formAccion == FormAccion.Modificar)
            {
                try
                {
                    tbNombre.Text = this.profesor.nombre;
                    tbMail.Text = this.profesor.mail;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z ]*$");

            if (!regex.IsMatch(tbNombre.Text) || this.tbNombre.Text == string.Empty || this.tbNombre.Text.Length > 60)
            {
                tbNombre.BackColor = colorError;
                nombreValidado = false;
            }
            else
            {
                tbNombre.BackColor = colorDefault;
                nombreValidado = true;
            }
        }

        private void tbMail_TextChanged(object sender, EventArgs e)
        {
            if (!this.tbMail.Text.Contains('@') || !this.tbMail.Text.Contains('.') || this.tbMail.Text == string.Empty || this.tbMail.Text.Length > 60)
            {
                tbMail.BackColor = colorError;
                mailValidado = false;
            }
            else
            {
                tbMail.BackColor = colorDefault;
                mailValidado = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nombreValidado && mailValidado)
            {
                try
                {
                    this.profesor.nombre = tbNombre.Text;
                    this.profesor.mail = tbMail.Text;

                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por validar", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}