using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MenuAgregarForm
{
    public partial class frmMenuAlumno : Form, IAutenticacion
    {
        private Alumno alumno;
        private List<Curso> cursos;
        private readonly FormAccion formAccion;

        private bool nombreValidado = false;
        private bool mailValidado = false;
        private bool abonadoValidado = false;
        private readonly Color colorDefault = SystemColors.Window;
        private readonly Color colorError = Color.Red;

        public frmMenuAlumno()
        {
            InitializeComponent();
            this.cursos = new List<Curso>();
        }

        public frmMenuAlumno(Alumno alumno, List<Curso> cursos, FormAccion formAccion) : this()
        {
            this.alumno = alumno;
            this.cursos = cursos;
            this.formAccion = formAccion;
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

            if(formAccion==FormAccion.Modificar)
            {
                try
                {
                    tbNombre.Text = this.alumno.nombre;
                    tbMail.Text = this.alumno.mail;
                    cbNacionalidad.SelectedItem = this.alumno.nacionalidad.ToString();
                    nupAbonado.Value = (decimal)(this.alumno.totalAbonado);
                    cbTipoDePago.SelectedItem = this.alumno.tipoDePago.ToString();
                    cbCurso.SelectedItem = this.alumno.curso.ToString();
                }
                catch(NullReferenceException)
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nombreValidado && mailValidado && abonadoValidado)
            {
                this.alumno.nombre = tbNombre.Text;
                this.alumno.mail = tbMail.Text;
                this.alumno.totalAbonado = Decimal.ToDouble(nupAbonado.Value);
                this.alumno.curso = cursos[cbCurso.SelectedIndex];

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Faltan datos por validar", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (this.validarNombre())
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
            if (this.validarMail())
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

        /// <summary>
        /// El monto abonado por el alumno debe ser minimo 1000 pesos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Definimos los metodos declarados en la interfaz
        /// </summary>
        /// <returns></returns>
        public bool validarNombre()
        {
            Regex regex = new Regex(@"^[a-zA-Zá-úÁ-Ú ]*$");

            return !regex.IsMatch(tbNombre.Text) || this.tbNombre.Text == string.Empty || this.tbNombre.Text.Length > 60;
        }

        public bool validarMail()
        {
            return !this.tbMail.Text.Contains('@') || !this.tbMail.Text.Contains('.') || this.tbMail.Text == string.Empty || this.tbMail.Text.Length > 60;
        }
    }
}