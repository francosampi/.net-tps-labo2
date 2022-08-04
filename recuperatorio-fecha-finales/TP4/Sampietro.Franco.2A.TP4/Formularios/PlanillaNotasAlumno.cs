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
    public partial class PlanillaNotasAlumno : Form
    {
        PlanillaAlumno pAl;

        public PlanillaNotasAlumno()
        {
            InitializeComponent();
            tbId.Enabled = false;
        }

        public PlanillaNotasAlumno(PlanillaAlumno pAl) : this()
        {
            this.pAl = pAl;

            tbAlumno.Text = pAl.nombreAlumno;
            tbProgVj.Text = pAl.notas[0].ToString();
            tbDibujo.Text = pAl.notas[1].ToString();
            tbDisenoG.Text = pAl.notas[2].ToString();
            tbDisenoB.Text = pAl.notas[3].ToString();
            tbProgW.Text = pAl.notas[4].ToString();
        }

        /// <summary>
        /// construir planilla de alumno con sus notas
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="notas"></param>
        public PlanillaNotasAlumno(string id, PlanillaAlumno pAl) : this(pAl)
        {
            tbId.Text = id;
        }

        /// <summary>
        /// validar en las notas que solo hayan digitos
        /// </summary>
        /// <returns></returns>
        private bool SoloDigitosEnNotas()
        {
            return tbDibujo.soloDigitosEnTextBox() &&
                tbDisenoB.soloDigitosEnTextBox() &&
                tbDisenoG.soloDigitosEnTextBox() &&
                tbProgVj.soloDigitosEnTextBox() &&
                tbProgW.soloDigitosEnTextBox();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (SoloDigitosEnNotas())
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Las notas deben ser numéricas", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
