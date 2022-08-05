using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmPlanillaNotas : Form
    {
        private static NotasDAO notasDao;
        private static event Action planillaAbierta;
        private static event Action<string, string, double> promedioGenerado;

        public frmPlanillaNotas()
        {
            InitializeComponent();
            notasDao = new NotasDAO();
            planillaAbierta += () => { btnModificar.Enabled = true;};
            planillaAbierta += () => { btnRemover.Enabled = true;};
            planillaAbierta += () => { btnPromedio.Enabled = true;};
            promedioGenerado = (s,s2,d) => { MessageBox.Show("El alumno '"+s+"' tiene de promedio un: "+d.ToString()+Environment.NewLine+s2, "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information); };
        }

        private void frmPlanillaNotas_Load(object sender, EventArgs e)
        {
            dgPlanilla.AllowUserToAddRows = false;
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
            int[] notasDefecto = { 0, 0, 0, 0, 0, 0 };

            PlanillaAlumno pAl = new PlanillaAlumno("Sin nombre", notasDefecto);
            Form frm = new PlanillaNotasAlumno(pAl);

            if(frm.ShowDialog()==DialogResult.OK)
            {
                if (notasDao.GuardarEnBD(pAl))
                {
                    ActualizarPlanilla();
                    MessageBox.Show("Alta realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar en Base de datos", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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

            try
            {
                for (int i = 2; i < 7; i++)
                {
                    double nota = Convert.ToDouble(dgPlanilla.CurrentRow.Cells[i].Value.ToString());

                    if (nota > 0)
                    {
                        promedio += nota;
                        promedioIndice++;
                    }
                }
                promedio /= promedioIndice;
                estado = promedio >= 6 ? "[APROBADO]" : "[DESAPROBADO]";
                promedioGenerado.Invoke(Convert.ToString(dgPlanilla.CurrentRow.Cells[1].Value), estado, promedio);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error: "+ex.Message, "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// modificar alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int[] notasAlumno = new int[] {
                Convert.ToInt32(dgPlanilla.CurrentRow.Cells[2].Value),
                Convert.ToInt32(dgPlanilla.CurrentRow.Cells[3].Value),
                Convert.ToInt32(dgPlanilla.CurrentRow.Cells[4].Value),
                Convert.ToInt32(dgPlanilla.CurrentRow.Cells[5].Value),
                Convert.ToInt32(dgPlanilla.CurrentRow.Cells[6].Value)
            };

            PlanillaAlumno pAl = new PlanillaAlumno(dgPlanilla.CurrentRow.Cells[1].Value.ToString(), notasAlumno);

            Form frm = new PlanillaNotasAlumno(dgPlanilla.CurrentRow.Cells[0].Value.ToString(), pAl);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (notasDao.EditarDeDB(dgPlanilla.CurrentRow.Cells[0].Value.ToString(), pAl))
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
            if(notasDao.BorrarDeDB(Convert.ToString(dgPlanilla.CurrentRow.Cells[0].Value)))
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
        /// actualiza el datagrid trayendo los datos de la base
        /// </summary>
        private async void ActualizarPlanilla()
        {
            try
            {
                List<string[]> listaFilas = await notasDao.LeerEnBD();

                dgPlanilla.Rows.Clear();
                listaFilas.ForEach(row => dgPlanilla.Rows.Add(row));
                planillaAbierta.Invoke();
                dgPlanilla.ClearSelection();
            }
            catch(Exception)
            {
                MessageBox.Show("Error al cargar la planilla", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}