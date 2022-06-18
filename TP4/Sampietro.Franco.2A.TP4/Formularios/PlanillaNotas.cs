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
        private static event Action<string, double> promedioGenerado;

        public frmPlanillaNotas()
        {
            InitializeComponent();
            notasDao = new NotasDAO(@"Server=localhost;Database=SistemaNotas;Trusted_Connection=True;");
            planillaRecienCargada = () => { btnLeer.Enabled = false; };
            promedioGenerado = (string s, double d) => { MessageBox.Show("El alumno '"+s+"' tiene de promedio un: "+d.ToString(), "Promedio", MessageBoxButtons.OK, MessageBoxIcon.Information); };
        }

        private void frmPlanillaNotas_Load(object sender, EventArgs e)
        {
            dgPlanilla.AllowUserToAddRows = false;
            dgAgregarAPlanilla.AllowUserToAddRows = false;
            dgAgregarAPlanilla.Rows.Add();
            notasDao.LeerEnBD(dgPlanilla);
        }

        private void btnGuardarBaseDatos_Click(object sender, EventArgs e)
        {
            notasDao.GuardarEnBD(dgAgregarAPlanilla);
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            dgPlanilla.Rows.Clear();
            notasDao.LeerEnBD(dgPlanilla);
            planillaRecienCargada.Invoke();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio=0;

            promedio+=Convert.ToDouble(dgAgregarAPlanilla.Rows[0].Cells["addProgramacionDeVideojuegos"].Value);
            promedio+=Convert.ToDouble(dgAgregarAPlanilla.Rows[0].Cells["addDibujoDeComics"].Value);
            promedio+=Convert.ToDouble(dgAgregarAPlanilla.Rows[0].Cells["addDisenoGrafico"].Value);
            promedio+=Convert.ToDouble(dgAgregarAPlanilla.Rows[0].Cells["addDisenoEnBlender"].Value);
            promedio+=Convert.ToDouble(dgAgregarAPlanilla.Rows[0].Cells["addProgramacionWeb"].Value);
            promedio /= 5;

            promedioGenerado.Invoke(Convert.ToString(dgAgregarAPlanilla.Rows[0].Cells["addAlumno"].Value), promedio);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}