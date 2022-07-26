using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmPlanillaNotas : Form
    {
        private static NotasDAO notasDao;
        private static string alumnoSinNombre = "[ALUMNO NUEVO]";
        private static event Action planillaAbierta;
        private static event Action<string, string, double> promedioGenerado;
        private static int tbDatosSize = 7;
        private TextBox[] tbDatos;

        public frmPlanillaNotas()
        {
            InitializeComponent();
            notasDao = new NotasDAO();
            tbDatos = new TextBox[tbDatosSize];
            planillaAbierta += () => { btnModificar.Enabled = true;};
            planillaAbierta += () => { btnRemover.Enabled = true;};
            planillaAbierta += () => { btnPromedio.Enabled = true;};
            promedioGenerado = (s,s2,d) => { MessageBox.Show("El alumno '"+s+"' tiene de promedio un: "+d.ToString()+Environment.NewLine+s2, "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information); };
        }

        private void frmPlanillaNotas_Load(object sender, EventArgs e)
        {
            this.tbDatos[0] = tbId;
            this.tbDatos[1] = tbAlumno;
            this.tbDatos[2] = tbProgVj;
            this.tbDatos[3] = tbDibujo;
            this.tbDatos[4] = tbDisenoG;
            this.tbDatos[5] = tbDisenoB;
            this.tbDatos[6] = tbProgW;
            dgPlanilla.AllowUserToAddRows = false;
            tbAlumno.PlaceholderText = alumnoSinNombre;
            btnModificar.Enabled = false;
            btnRemover.Enabled = false;
            btnPromedio.Enabled = false;
            ActualizarPlanilla();
        }

        /// <summary>
        /// insertar alumno en base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarBaseDatos_Click(object sender, EventArgs e)
        {
            if (ValidarDatosPrincipalNotas() && notasDao.GuardarEnBD(tbDatos, Convert.ToString(tbDatos[0].Text)))
            {
                ActualizarPlanilla();
                MessageBox.Show("Alta realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar en Base de datos", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// generar promedio de alumno y mostrarla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio=0;
            double promedioIndice = 0;
            string estado;

            if (ValidarDatosPrincipalNotas())
            {
                try
                {
                    for (int i = 2; i < tbDatosSize; i++)
                    {
                        double nota = Convert.ToDouble(this.tbDatos[i].Text);

                        if (nota > 0)
                        {
                            promedio += Convert.ToDouble(this.tbDatos[i].Text);
                            promedioIndice++;
                        }
                    }
                    promedio /= promedioIndice;
                    estado = promedio >= 6 ? "[APROBADO]" : "[DESAPROBADO]";
                    promedioGenerado.Invoke(Convert.ToString(this.tbDatos[1].Text), estado, promedio);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: "+ex.Message, "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// cerrar planilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// traspasar de datos de una fila a la principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgPlanilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < tbDatosSize; i++)
            {
                this.tbDatos[i].Text = dgPlanilla.CurrentRow.Cells[i].Value.ToString();
            }
        }

        /// <summary>
        /// modificar alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosPrincipalNotas())
            {
                string[] celdasMain = new string[tbDatosSize];

                for (int i = 0; i < celdasMain.Length; i++)
                {
                    celdasMain[i] = Convert.ToString(this.tbDatos[i].Text);
                }

                if (notasDao.EditarDeDB(Convert.ToString(this.tbDatos[0].Text), celdasMain))
                {
                    ActualizarPlanilla();
                    MessageBox.Show("Modificacion realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al modificar al alumno", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// remover alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(notasDao.BorrarDeDB(Convert.ToString(this.tbDatos[0].Text)))
            {
                ActualizarPlanilla();
                MessageBox.Show("Baja realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al eliminar alumno", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// chequea que las celdas correspondiente a las notas solo contengan valores numericos
        /// </summary>
        /// <returns></returns>
        private bool ValidarDatosPrincipalNotas()
        {
            for (int i = 2; i < tbDatosSize; i++)
            {
                if (!soloDigitosEnDatosPrincipales())
                {
                    MessageBox.Show("Las notas no permiten caracteres especiales", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// actualiza el datagrid trayendo los datos de la base
        /// </summary>
        private async void ActualizarPlanilla()
        {
            try
            {
                dgPlanilla.Rows.Clear();
                List<string[]> listaFilas = await notasDao.LeerEnBD();

                listaFilas.ForEach(row => dgPlanilla.Rows.Add(row));
                //tbAlumno.Text = listaFilas[0];
                //tbProgVj.Text = listaFilas[1];
                //tbDibujo.Text = listaFilas[2];
                //tbDisenoG.Text = listaFilas[3];
                //tbDisenoB.Text = listaFilas[4];
                //tbProgW.Text = listaFilas[5];

                planillaAbierta.Invoke();
            }
            catch(Exception)
            {
                MessageBox.Show("Error al cargar la planilla", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// validar en el form de datos principales que solo hayan digitos
        /// </summary>
        /// <returns></returns>
        private bool soloDigitosEnDatosPrincipales()
        {
            return tbDibujo.soloDigitosEnTextBox() &&
                tbDisenoB.soloDigitosEnTextBox() &&
                tbDisenoG.soloDigitosEnTextBox() &&
                tbProgVj.soloDigitosEnTextBox() &&
                tbProgW.soloDigitosEnTextBox();
        }
    }
}