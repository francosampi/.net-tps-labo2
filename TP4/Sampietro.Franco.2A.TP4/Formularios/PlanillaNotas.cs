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
        private DataGridViewRow rowMain;

        public frmPlanillaNotas()
        {
            InitializeComponent();
            notasDao = new NotasDAO(@"Server=localhost;Database=SistemaNotas;Trusted_Connection=True;");
            planillaAbierta = () => { btnLeer.Enabled = true;};
            planillaAbierta += () => { btnModificar.Enabled = true;};
            planillaAbierta += () => { btnRemover.Enabled = true;};
            planillaAbierta += () => { btnPromedio.Enabled = true;};
            promedioGenerado = (s,s2,d) => { MessageBox.Show("El alumno '"+s+"' tiene de promedio un: "+d.ToString()+Environment.NewLine+s2, "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information); };
        }

        private void frmPlanillaNotas_Load(object sender, EventArgs e)
        {
            dgPlanilla.AllowUserToAddRows = false;
            dgAgregarAPlanilla.AllowUserToAddRows = false;
            dgAgregarAPlanilla.Rows.Add();
            this.rowMain = dgAgregarAPlanilla.Rows[0];
            this.rowMain.Cells[1].Value=alumnoSinNombre;

            btnModificar.Enabled = false;
            btnRemover.Enabled = false;
            btnPromedio.Enabled = false;
        }

        /// <summary>
        /// insertar alumno en base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarBaseDatos_Click(object sender, EventArgs e)
        {
            if (ValidarRowPrincipalNotas() && notasDao.GuardarEnBD(dgAgregarAPlanilla, Convert.ToString(this.rowMain.Cells[1].Value)))
            {
                MessageBox.Show("Alta realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// traer lista de base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnLeer_Click(object sender, EventArgs e)
        {
            dgPlanilla.Rows.Clear();
            List<string[]> listaFilas = await notasDao.LeerEnBD();

            listaFilas.ForEach(row => dgPlanilla.Rows.Add(row));

            planillaAbierta.Invoke();
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

            if (ValidarRowPrincipalNotas())
            {
                try
                {
                    for (int i = 2; i < this.rowMain.Cells.Count; i++)
                    {
                        double nota = Convert.ToDouble(this.rowMain.Cells[i].Value);

                        if (nota > 0)
                        {
                            promedio += Convert.ToDouble(this.rowMain.Cells[i].Value);
                            promedioIndice++;
                        }
                    }
                    promedio /= promedioIndice;
                    estado = promedio >= 6 ? "[APROBADO]" : "[DESAPROBADO]";
                    promedioGenerado.Invoke(Convert.ToString(this.rowMain.Cells[1].Value), estado, promedio);
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
            for (int i = 0; i < this.rowMain.Cells.Count; i++)
            {
                this.rowMain.Cells[i].Value = dgPlanilla.CurrentRow.Cells[i].Value;
            }
        }

        /// <summary>
        /// modificar alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarRowPrincipalNotas())
            {
                string[] celdasMain = new string[this.rowMain.Cells.Count];

                for (int i = 0; i < celdasMain.Length; i++)
                {
                    celdasMain[i] = Convert.ToString(this.rowMain.Cells[i].Value);
                }

                if (notasDao.EditarDeDB(Convert.ToString(this.rowMain.Cells[0].Value), celdasMain))
                {
                    MessageBox.Show("Modificacion realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if(notasDao.BorrarDeDB(Convert.ToString(this.rowMain.Cells[0].Value)))
            {
                MessageBox.Show("Baja realizada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// chequea que las celdas correspondiente a las notas solo contengan valores numericos
        /// </summary>
        /// <returns></returns>
        private bool ValidarRowPrincipalNotas()
        {
            for (int i = 2; i < this.rowMain.Cells.Count; i++)
            {
                if (!this.rowMain.soloDigitosEnCelda(i))
                {
                    MessageBox.Show("Las notas no permiten caracteres especiales", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
}