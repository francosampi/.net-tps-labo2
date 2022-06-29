using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class NotasDAO
    {
        public string cadenaConexion;
        public SqlConnection conexion;
        public SqlCommand comando;
        public SqlDataReader lector;

        public NotasDAO(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            this.conexion = new SqlConnection(this.cadenaConexion);
            this.comando = new SqlCommand();
        }

        /// <summary>
        /// Restaura la tabla en la base de datos con los cambios del datagrid
        /// </summary>
        /// <returns></returns>
        public bool GuardarEnBD(DataGridView dg, string nombre)
        {
            DialogResult dialogResult = MessageBox.Show("Agregar alumno '"+nombre+"'?", "Agregar alumno a la base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
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
            return false;
        }

        /// <summary>
        /// Trae los datos de la base y los muestra en el datagrid
        /// </summary>
        /// <param name="dg"></param>
        /// <returns></returns>
        public async Task<List<string[]>> LeerEnBD()
        {
            List<string[]> listaFilas = new List<string[]>();

            await Task.Run(() =>
            {
                try
                {
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
                        int disenografico = lector.GetInt32(4);
                        int disenoblender = lector.GetInt32(5);
                        int programacionweb = lector.GetInt32(6);

                        string[] row = {
                            id.ToString(),
                            alumno,
                            programaciondevideojuegos.ToString(),
                            dibujodecomics.ToString(),
                            disenografico.ToString(),
                            disenoblender.ToString(), 
                            programacionweb.ToString()
                        };
                        listaFilas.Add(row);
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

            return listaFilas;
        }

        /// <summary>
        /// actualizar alumno en la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="celdas"></param>
        /// <returns></returns>
        public bool EditarDeDB(string id, string[] celdas)
        {
            DialogResult dialogResult = MessageBox.Show("Actualizar alumno en id " + id, "Actualizar alumno de base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    this.comando.CommandText = "UPDATE notas SET alumno = @alumno, " +
                        "programaciondevideojuegos = @programaciondevideojuegos, " +
                        "dibujodecomics = @dibujodecomics, " +
                        "disenografico = @disenografico, " +
                        "disenoblender = @disenoblender, " +
                        "programacionweb = @programacionweb " +
                        "WHERE id in (" + id + ")";
                    this.comando.Connection = this.conexion;
                    this.conexion.Open();

                    this.comando.Parameters.Clear();
                    this.comando.Parameters.AddWithValue("@alumno", celdas[1].Trim());
                    this.comando.Parameters.AddWithValue("@programaciondevideojuegos", celdas[2].Trim());
                    this.comando.Parameters.AddWithValue("@dibujodecomics", celdas[3].Trim());
                    this.comando.Parameters.AddWithValue("@disenografico", celdas[4].Trim());
                    this.comando.Parameters.AddWithValue("@disenoblender", celdas[5].Trim());
                    this.comando.Parameters.AddWithValue("@programacionweb", celdas[6].Trim());                    

                    if (this.comando.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Sin columnas afectadas", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                finally
                {
                    if (this.conexion.State == ConnectionState.Open)
                    {
                        this.conexion.Close();
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// borrar alumno de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool BorrarDeDB(string id)
        {
            DialogResult dialogResult = MessageBox.Show("Eliminar alumno en id "+id, "Borrar alumno de base de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    this.comando.CommandText = "DELETE from notas WHERE id in (" + id+")";
                    this.comando.Connection = this.conexion;
                    this.conexion.Open();

                    if (this.comando.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Sin columnas afectadas", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar alumno en id " + id, "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                finally
                {
                    if (this.conexion.State == ConnectionState.Open)
                    {
                        this.conexion.Close();
                    }
                }
            }
            return true;
        }
    }
}
