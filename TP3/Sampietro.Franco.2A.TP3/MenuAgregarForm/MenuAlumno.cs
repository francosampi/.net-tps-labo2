using Entidades;
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

namespace MenuAgregarForm
{
    public partial class frmAgregar : Form
    {
        Alumno alumno;
        List<Curso> cursos;
        private bool nombreValidado = false;
        private bool mailValidado = false;
        private bool abonadoValidado = false;
        Color colorDefault = SystemColors.Window;
        Color colorError = Color.Red;

        public frmAgregar()
        {
            InitializeComponent();
            cursos = new List<Curso>();
        }

        public frmAgregar(Alumno alumno, List<Curso> cursos) : this()
        {
            this.alumno = alumno;
            this.cursos = cursos;
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            cbNacionalidad.Items.Add("Argentina");
            cbNacionalidad.Items.Add("Extranjera");
            cbNacionalidad.SelectedIndex = 0;

            cbTipoDePago.Items.Add("Transferencia");
            cbTipoDePago.Items.Add("Tarjeta");
            cbTipoDePago.SelectedIndex = 0;

            foreach(Curso curso in this.cursos)
            {
                cbCurso.Items.Add(curso.ToString());
            }
            cbCurso.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nombreValidado && mailValidado && abonadoValidado)
            {
                try
                {
                    this.alumno.nombre = tbNombre.Text;
                    this.alumno.mail = tbMail.Text;
                    this.alumno.totalAbonado = Decimal.ToDouble(nupAbonado.Value);
                    this.alumno.curso = cursos[cbCurso.SelectedIndex];

                    this.DialogResult = DialogResult.OK;
                }
                catch(Exception ex)
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por validar", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!this.tbMail.Text.Contains('@') || !this.tbMail.Text.Contains('.') || this.tbMail.Text==string.Empty || this.tbMail.Text.Length>60)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void nupAbonado_ValueChanged(object sender, EventArgs e)
        {
            double abonado = Decimal.ToDouble(nupAbonado.Value);

            if (abonado<1000)
            {
                nupAbonado.BackColor = colorError;
                abonadoValidado = false;
            }
            else
            {
                nupAbonado.BackColor = colorDefault;
                abonadoValidado = true;
            }
        }
    }
}