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
                this.alumno.nombre = tbNombre.Text;
                this.alumno.mail = tbMail.Text;
                this.alumno.totalAbonado = Decimal.ToDouble(nupAbonado.Value);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Faltan datos por validar", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z ]*$");

            if (!regex.IsMatch(tbNombre.Text) || this.tbNombre.Text == string.Empty)
            {
                tbNombre.BackColor = Color.Red;
                nombreValidado = false;
            }
            else
            {
                tbNombre.BackColor = SystemColors.Window;
                nombreValidado = true;
            }
        }

        private void tbMail_TextChanged(object sender, EventArgs e)
        {
            if (!this.tbMail.Text.Contains('@') || !this.tbMail.Text.Contains('.') || this.tbMail.Text==string.Empty)
            {
                tbMail.BackColor = Color.Red;
                mailValidado = false;
            }
            else
            {
                tbMail.BackColor = SystemColors.Window;
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
                nupAbonado.BackColor = Color.Red;
                abonadoValidado = false;
            }
            else
            {
                nupAbonado.BackColor = SystemColors.Window;
                abonadoValidado = true;
            }
        }
    }
}