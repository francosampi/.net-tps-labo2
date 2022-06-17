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
        private static string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public frmPlanillaNotas()
        {
            InitializeComponent();
        }

        static frmPlanillaNotas()
        {
            cadenaConexion = @"Server=localhost;Database=SistemaNotas;Trusted_Connection=True;";
        }

        private void frmPlanillaNotas_Load(object sender, EventArgs e)
        {
            this.conexion = new SqlConnection(frmPlanillaNotas.cadenaConexion);
            dgPlanilla.AllowUserToAddRows = false;
        }

        private async void btnGuardarBaseDatos_Click(object sender, EventArgs e)
        {
            await GuardarEnBD();
        }

        /// <summary>
        /// Restaura la tabla en la base de datos con los cambios del datagrid
        /// </summary>
        /// <returns></returns>
        private async Task<bool> GuardarEnBD()
        {
            await Task.Run(() =>
            {
                try
                {
                    this.comando = new SqlCommand();
                    this.comando.CommandText = "delete notas INSERT INTO notas VALUES (@alumno, @programaciondevideojuegos, @dibujodecomics, @disenoblender, @programacionweb, @promedio)";
                    this.comando.Connection = this.conexion;
                    this.conexion.Open();

                    foreach (DataGridViewRow row in dgPlanilla.Rows)
                    {
                        this.comando.Parameters.Clear();

                        this.comando.Parameters.AddWithValue("@alumno", Convert.ToString(row.Cells["Alumno"].Value).Trim());
                        this.comando.Parameters.AddWithValue("@programaciondevideojuegos", Convert.ToString(row.Cells["ProgramacionDeVideojuegos"].Value).Trim());
                        this.comando.Parameters.AddWithValue("@dibujodecomics", Convert.ToString(row.Cells["DibujoDeComics"].Value).Trim());
                        this.comando.Parameters.AddWithValue("@disenoblender", Convert.ToString(row.Cells["Diseno3DEnBlender"].Value).Trim());
                        this.comando.Parameters.AddWithValue("@programacionweb", Convert.ToString(row.Cells["ProgramacionWeb"].Value).Trim());
                        this.comando.Parameters.AddWithValue("@promedio", Convert.ToString(row.Cells["Promedio"].Value).Trim());

                        if (this.comando.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Sin columnas afectadas", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocurrio un error: " + e.Message, "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (this.conexion.State == ConnectionState.Open)
                    {
                        this.conexion.Close();
                    }
                }
                return true;
            });
            return false;
        }

        /// <summary>
        /// Agrega manualmente una nueva fila de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgPlanilla.Rows.Add();
            dgPlanilla.Rows[dgPlanilla.Rows.Count - 1].Cells["Alumno"].Value = "[SIN NOMBRE]";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}