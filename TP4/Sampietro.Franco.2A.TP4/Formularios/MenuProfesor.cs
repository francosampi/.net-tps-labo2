using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Entidades;

namespace MenuAgregarProfesorForm
{
    public partial class frmMenuProfesor : Form, IAutenticacion
    {
        private Profesor profesor;
        private List<Curso> cursos;
        private readonly FormAccion formAccion;
        private bool nombreValidado = false;
        private bool mailValidado = false;
        private readonly Color colorDefault = SystemColors.Window;
        private readonly Color colorError = Color.Red;

        public frmMenuProfesor()
        {
            InitializeComponent();
        }

        public frmMenuProfesor(Profesor profesor, List<Curso> cursos, FormAccion formAccion) : this()
        {
            this.profesor = profesor;
            this.formAccion = formAccion;
            this.cursos = cursos;
        }

        /// <summary>
        /// Si se trata de un formulario de modificacion, traer los atributos del objeto a modificar y pasarlos al objeto manejador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenuProfesor_Load(object sender, EventArgs e)
        {
            foreach (Curso curso in this.cursos)
            {
                cbCurso.Items.Add(curso.ToString());
            }
            cbCurso.SelectedIndex = 0;

            if (formAccion == FormAccion.Modificar)
            {
                try
                {
                    tbNombre.Text = this.profesor.nombre;
                    tbMail.Text = this.profesor.mail;
                    cbCurso.SelectedItem = this.profesor.curso.ToString();
                }
                catch (NullReferenceException)
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
        }

        /// <summary>
        /// si alguno de los campos cambian (apretando una tecla o borrando un caracter), validar que lo que quede en ese campo sea valido para ser asignado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Si se encuentran los campos validados, se asignan los atributos al objeto del profesor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nombreValidado && mailValidado)
            {
                this.profesor.nombre = tbNombre.Text;
                this.profesor.mail = tbMail.Text;
                this.profesor.curso = cursos[cbCurso.SelectedIndex];

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Faltan datos por validar", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Se cancela la modificacion del formulario y se cierra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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