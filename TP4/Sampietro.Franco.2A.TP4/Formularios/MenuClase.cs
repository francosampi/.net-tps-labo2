using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmMenuClase : Form
    {
        private Clase clase;
        private List<Profesor> profesores;
        private readonly FormAccion formAccion;

        public frmMenuClase()
        {
            InitializeComponent();
            this.profesores = new List<Profesor>();
        }

        public frmMenuClase(Clase clase, List<Profesor> profesores, FormAccion formAccion) : this()
        {
            this.clase = clase;
            this.profesores = profesores;
            this.formAccion = formAccion;
        }

        private void frmMenuClase_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = profesores;
            cbDocente.DataSource = bs;
            cbDocente.SelectedIndex = 0;

            cbDias.Items.Add("Lunes");
            cbDias.Items.Add("Martes");
            cbDias.Items.Add("Miercoles");
            cbDias.Items.Add("Jueves");
            cbDias.Items.Add("Viernes");
            cbDias.SelectedIndex = 0;

            cbHorario.Items.Add("Mañana");
            cbHorario.Items.Add("Tarde");
            cbHorario.SelectedIndex = 0;

            if (formAccion == FormAccion.Modificar)
            {
                try
                {
                    cbDocente.SelectedIndex = cbDocente.FindString(this.clase.profesor.nombre);
                    cbHorario.SelectedItem = this.clase.horario.ToString();
                    cbDias.SelectedItem = this.clase.dias.ToString();
                }
                catch (NullReferenceException)
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.clase.profesor = (Profesor)profesores[cbDocente.SelectedIndex];
            this.clase.dias = (Dias)cbDias.SelectedIndex;
            this.clase.horario = (Horario)cbHorario.SelectedIndex;

            this.DialogResult = DialogResult.OK;
        }

        private void cbDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profesor profesorSeleccionado = (Profesor)profesores[cbDocente.SelectedIndex];
            tbCurso.Text= profesorSeleccionado.curso.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
