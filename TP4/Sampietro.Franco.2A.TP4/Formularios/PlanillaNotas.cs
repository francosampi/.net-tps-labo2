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
        NotasDAO notasDao;

        public frmPlanillaNotas()
        {
            InitializeComponent();
            this.notasDao = new NotasDAO(@"Server=localhost;Database=SistemaNotas;Trusted_Connection=True;");
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
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}