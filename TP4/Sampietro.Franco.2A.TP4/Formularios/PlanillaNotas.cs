using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmPlanillaNotas : Form
    {
        private static NotasDAO notasDao;
        private static event Action planillaRecienCargada;
        private static event Action planillaRecienEditada;
        private static event Action<string, double> promedioGenerado;
        private DataGridViewRow rowMain;

        public frmPlanillaNotas()
        {
            InitializeComponent();
            notasDao = new NotasDAO(@"Server=localhost;Database=SistemaNotas;Trusted_Connection=True;");
            planillaRecienCargada = () => { btnLeer.Enabled = false; };
            planillaRecienEditada = () => { btnLeer.Enabled = true; };
            promedioGenerado = (s,d) => { MessageBox.Show("El alumno '"+s+"' tiene de promedio un: "+d.ToString(), "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information); };
        }

        private void frmPlanillaNotas_Load(object sender, EventArgs e)
        {
            dgPlanilla.AllowUserToAddRows = false;
            dgAgregarAPlanilla.AllowUserToAddRows = false;
            dgAgregarAPlanilla.Rows.Add();
            this.rowMain = dgAgregarAPlanilla.Rows[0];
        }

        private void btnGuardarBaseDatos_Click(object sender, EventArgs e)
        {
            notasDao.GuardarEnBD(dgAgregarAPlanilla);
            planillaRecienEditada.Invoke();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            dgPlanilla.Rows.Clear();
            List<string[]> listaFilas = await notasDao.LeerEnBD();

            listaFilas.ForEach(row => dgPlanilla.Rows.Add(row));

            if (dgPlanilla.Rows.Count > 0)
            {
                planillaRecienCargada.Invoke();
            }
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio=0;
            double promedioIndice = 0;

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
                promedioGenerado.Invoke(Convert.ToString(this.rowMain.Cells[1].Value), promedio);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Las notas no permiten caracteres especiales", "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgPlanilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rowMain.Cells["addId"].Value = dgPlanilla.CurrentRow.Cells["Id"].Value;
            this.rowMain.Cells["addAlumno"].Value = dgPlanilla.CurrentRow.Cells["Alumno"].Value;
            this.rowMain.Cells["addProgramacionDeVideojuegos"].Value = dgPlanilla.CurrentRow.Cells["ProgramacionDeVideojuegos"].Value;
            this.rowMain.Cells["addDibujoDeComics"].Value = dgPlanilla.CurrentRow.Cells["DibujoDeComics"].Value;
            this.rowMain.Cells["addDisenoGrafico"].Value = dgPlanilla.CurrentRow.Cells["DisenoGrafico"].Value;
            this.rowMain.Cells["addDisenoEnBlender"].Value = dgPlanilla.CurrentRow.Cells["DisenoEnBlender"].Value;
            this.rowMain.Cells["addProgramacionWeb"].Value = dgPlanilla.CurrentRow.Cells["ProgramacionWeb"].Value;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(notasDao.BorrarDeDB(Convert.ToString(this.rowMain.Cells[0].Value)))
            {
                dgPlanilla.Rows.Remove(dgPlanilla.CurrentRow);
                planillaRecienEditada.Invoke();
            }
        }
    }
}