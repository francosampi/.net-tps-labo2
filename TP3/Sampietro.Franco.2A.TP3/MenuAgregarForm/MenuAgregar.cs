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
            cbTipoDePago.Items.Add("Argentina");
            cbTipoDePago.Items.Add("Extranjera");

            foreach(Curso curso in this.cursos)
            {
                cbCurso.Items.Add(curso.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(tbNombre.Text))
            {
                tbNombre.BackColor = Color.Red;
            }
            else
            {
                tbNombre.BackColor = SystemColors.Window;
                this.alumno.nombre = tbNombre.Text;
            }
        }

        private void tbMail_TextChanged(object sender, EventArgs e)
        {
            if (!this.tbMail.Text.Contains('@') || !this.tbMail.Text.Contains('.'))
            {
                tbMail.BackColor = Color.Red;
            }
            else
            {
                tbMail.BackColor = SystemColors.Window;
                this.alumno.mail = tbMail.Text;
            }
        }
    }
}