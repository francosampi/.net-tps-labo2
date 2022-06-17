using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class NotasDAO
    {
        private string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public NotasDAO(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            this.conexion = new SqlConnection(this.cadenaConexion);
        }

        /// <summary>
        /// Restaura la tabla en la base de datos con los cambios del datagrid
        /// </summary>
        /// <returns></returns>
        public bool GuardarEnBD(DataGridView dg)
        {
            try
            {
                this.comando.CommandText = "INSERT INTO notas VALUES " +
                    "(@alumno, @programaciondevideojuegos, @dibujodecomics, @disenografico, @disenoblender, @programacionweb)";
                this.comando.Connection = this.conexion;
                this.conexion.Open();

                foreach (DataGridViewRow row in dg.Rows)
                {
                    this.comando.Parameters.Clear();

                    this.comando.Parameters.AddWithValue("@alumno", Convert.ToString(row.Cells["AddAlumno"].Value).Trim());
                    this.comando.Parameters.AddWithValue("@programaciondevideojuegos", Convert.ToString(row.Cells["addProgramacionDeVideojuegos"].Value).Trim());
                    this.comando.Parameters.AddWithValue("@dibujodecomics", Convert.ToString(row.Cells["addDibujoDeComics"].Value).Trim());
                    this.comando.Parameters.AddWithValue("@disenografico", Convert.ToString(row.Cells["addDisenoGrafico"].Value).Trim());
                    this.comando.Parameters.AddWithValue("@disenoblender", Convert.ToString(row.Cells["addDisenoEnBlender"].Value).Trim());
                    this.comando.Parameters.AddWithValue("@programacionweb", Convert.ToString(row.Cells["addProgramacionWeb"].Value).Trim());

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
        }

        /// <summary>
        /// Trae los datos de la base y los muestra en el datagrid
        /// </summary>
        /// <param name="dg"></param>
        /// <returns></returns>
        public bool LeerEnBD(DataGridView dg)
        {
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandText = "SELECT * FROM notas";
                this.comando.Connection = this.conexion;
                this.conexion.Open();

                this.lector = this.comando.ExecuteReader();

                while (lector.Read())
                {
                    int id = lector.GetInt32(0);
                    string alumno = lector.GetString(1);
                    int programaciondevideojuegos = lector.GetInt32(2);
                    int dibujodecomics = lector.GetInt32(3);
                    int disenografico = lector.GetInt32(3);
                    int disenoblender = lector.GetInt32(4);
                    int programacionweb = lector.GetInt32(5);

                    dg.Rows.Add(id, alumno, programaciondevideojuegos, dibujodecomics, disenografico, disenoblender, programacionweb);
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
        }
    }
}
