using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using MenuAgregarForm;
using MenuAgregarProfesorForm;
using SerializadorXML;

namespace MenuPrincipalForm
{
    public partial class MenuPrincipal : Form
    {
        private Instituto instituto;
        private int listadoIndex;
        string nombreArchivoListaAlumnos = "ListaDeAlumnos";
        string nombreArchivoListaProfesores = "ListaDeProfesores";
        string nombreArchivoListaClases = "ListaDeClases";

        /// <summary>
        /// Inicializar instituto con nombre, cargar cursos que da, y traer de los xml alumnos, profesores y clases que se dan
        /// </summary>
        public MenuPrincipal()
        {
            InitializeComponent();
            this.instituto = new Instituto("Escuelita de Artes Multimediales");

            Curso cr1 = new Curso("Programacion de Videojuegos", 6000, Modalidad.Virtual, Nivel.Basico);
            Curso cr2 = new Curso("Dibujo de Cómics", 4500, Modalidad.Presencial, Nivel.Basico);
            Curso cr3 = new Curso("Diseño 3D en Blender", 7500, Modalidad.Virtual, Nivel.Avanzado);
            Curso cr4 = new Curso("Diseño Gráfico", 7000, Modalidad.Virtual, Nivel.Basico);
            Curso cr5 = new Curso("Programacion Web", 8000, Modalidad.Virtual, Nivel.Avanzado);

            this.instituto.cursos.Add(cr1);
            this.instituto.cursos.Add(cr2);
            this.instituto.cursos.Add(cr3);
            this.instituto.cursos.Add(cr4);
            this.instituto.cursos.Add(cr5);

            this.instituto.alumnos = ClaseSerializadoraXML.deserializarXML<Alumno>(nombreArchivoListaAlumnos);
            this.instituto.profesores = ClaseSerializadoraXML.deserializarXML<Profesor>(nombreArchivoListaProfesores);
            this.instituto.clases = ClaseSerializadoraXML.deserializarXML<Clase>(nombreArchivoListaClases);
        }

        /// <summary>
        /// Por defecto el formulario cargará la lista de alumnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.listadoIndex = 0;
            cargarEnListBox<Alumno>(lbListado, this.instituto.alumnos);
        }

        /// <summary>
        /// nullear el datasource de la listbox para asignarsela a otra lista de entidades (alumnos, profesores o clases)
        /// mostrar detalles de la entidad seleccionada por defecto (si la listbox posee al menos una)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lb"></param>
        /// <param name="list"></param>
        private void cargarEnListBox<T>(ListBox lb, List<T> list) where T : class
        {
            lb.DataSource = null;
            lb.Items.Clear();
            lb.DataSource = list;
            lb.ClearSelected();

            try
            {
                foreach (T item in list)
                {
                    if (item is not null)
                    {
                        lb.Items.Add(item).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                tbDetalles.Text = ex.Message;
            }

            if (lbListado.Items.Count!=0)
            {
                lbListado.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// click en los botones de arriba para cargar su lista en la listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.listadoIndex = 0;
            cargarEnListBox<Alumno>(lbListado, this.instituto.alumnos);
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            this.listadoIndex = 1;
            cargarEnListBox<Profesor>(lbListado, this.instituto.profesores);
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            this.listadoIndex = 2;
            cargarEnListBox<Clase>(lbListado, this.instituto.clases);
        }

        /// <summary>
        /// Al cambiar de item seleccionado de cada una de las listas, mostrar su detalle a la derecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (this.listadoIndex)
                {
                    case 0:
                        escribirDetalleAlumno(tbDetalles);
                        btnAgregar.Enabled = true;
                        btnModificar.Enabled = true;
                        btnRemover.Enabled = true;
                        break;
                    case 1:
                        escribirDetalleProfesor(tbDetalles);
                        btnAgregar.Enabled = true;
                        btnModificar.Enabled = true;
                        btnRemover.Enabled = true;
                        break;
                    case 2:
                        escribirDetalleClase(tbDetalles);
                        btnAgregar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnRemover.Enabled = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                tbDetalles.Text = ex.Message;
            }
        }

        /// <summary>
        /// Escribir en textbox los detalles de cada entidad
        /// </summary>
        /// <param name="tb"></param>
        private void escribirDetalleAlumno(TextBox tb)
        {
            Alumno alumnoSeleccionado;
            alumnoSeleccionado = (Alumno)this.lbListado.SelectedItem;

            if (alumnoSeleccionado is not null)
            {
                string infoAlumno = alumnoSeleccionado.Ficha();

                tb.Text = infoAlumno;
            }
        }

        private void escribirDetalleClase(TextBox tb)
        {
            Clase claseSeleccionada;
            claseSeleccionada = (Clase)this.lbListado.SelectedItem;

            if (claseSeleccionada is not null)
            {
                string infoClase = claseSeleccionada.Ficha();

                tb.Text = infoClase;
            }
        }

        private void escribirDetalleProfesor(TextBox tb)
        {
            Profesor profesorSeleccionado;
            profesorSeleccionado = (Profesor)this.lbListado.SelectedItem;

            if (profesorSeleccionado is not null)
            {
                string infoProfesor = profesorSeleccionado.Ficha();

                tb.Text = infoProfesor;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (this.listadoIndex)
            {
                case 0:
                {
                    Alumno alumnoNuevo = new Alumno();

                    try
                    {
                        Form menuAlumno = new frmMenuAlumno(alumnoNuevo, this.instituto.cursos, FormAccion.Agregar);
                        DialogResult resultado = menuAlumno.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            this.instituto.alumnos.Add(alumnoNuevo);
                            cargarEnListBox<Alumno>(lbListado, this.instituto.alumnos);
                            MessageBox.Show("Se ha cargado al alumno correctamente", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error al cargar al alumno", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                break;
                case 1:
                {
                    Profesor profesorNuevo = new Profesor();

                    try
                    {
                        Form menuProfesor = new frmMenuProfesor(profesorNuevo, FormAccion.Agregar);
                        DialogResult resultado = menuProfesor.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            this.instituto.profesores.Add(profesorNuevo);
                            cargarEnListBox<Profesor>(lbListado, this.instituto.profesores);
                            MessageBox.Show("Se ha cargado al profesor correctamente", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error al cargar al alumno", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                break;
            }
        }

        /// <summary>
        /// Creo un objeto de tipo (entidad que quiera modificar) y la uso de manejador, para que los datos del form sean identicos.
        /// El form se encarga de traer los datos del objeto manejador para poder ser modificados y luego poder igualarlo a la entidad seleccionada.
        /// Se notifica si salio todo bien, o no, y recarga la lista del tipo entidad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            switch (this.listadoIndex)
            {
                case 0:
                    {
                        Alumno alumnoSeleccionado = (Alumno)this.lbListado.SelectedItem;
                        Alumno alumnoManejador = alumnoSeleccionado;

                        try
                        {
                            Form menuAlumno = new frmMenuAlumno(alumnoManejador, this.instituto.cursos, FormAccion.Modificar);
                            DialogResult resultado = menuAlumno.ShowDialog();

                            if (resultado == DialogResult.OK)
                            {
                                alumnoSeleccionado = alumnoManejador;
                                cargarEnListBox<Alumno>(lbListado, this.instituto.alumnos);
                                MessageBox.Show("Se ha modificado al alumno correctamente", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ocurrió un error al modificar al alumno", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 1:
                    {
                        Profesor profesorSeleccionado = (Profesor)this.lbListado.SelectedItem;
                        Profesor profesorManejador = profesorSeleccionado;

                        try
                        {
                            Form menuProfesor = new frmMenuProfesor(profesorManejador, FormAccion.Modificar);
                            DialogResult resultado = menuProfesor.ShowDialog();

                            if (resultado == DialogResult.OK)
                            {
                                profesorSeleccionado = profesorManejador;
                                cargarEnListBox<Profesor>(lbListado, this.instituto.profesores);
                                MessageBox.Show("Se ha modificado al profesor correctamente", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ocurrió un error al modificar al profesor", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Llamar funcion para guardar en carpeta del proyecto los archivos XML correspondientes al tipo de entidad (archivo XML de alumnos, profesores o clases)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarXML_Click(object sender, EventArgs e)
        {
            switch (this.listadoIndex)
            {
                case 0:
                    guardarListaEntidadesXML<Alumno>(this.instituto.alumnos, nombreArchivoListaAlumnos);
                    break;
                case 1:
                    guardarListaEntidadesXML<Profesor>(this.instituto.profesores, nombreArchivoListaProfesores);
                    break;
                case 2:
                    guardarListaEntidadesXML<Clase>(this.instituto.clases, nombreArchivoListaClases);
                    break;
            }
        }

        /// <summary>
        /// Click en remover para, si hay una entidad seleccionada, removerla de su lista correspondiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            switch (this.listadoIndex)
            {
                case 0:
                    removerElementoDeLista<Alumno>(this.instituto.alumnos, "alumno");
                    break;
                case 1:
                    removerElementoDeLista<Profesor>(this.instituto.profesores, "profesor");
                    break;
                case 2:
                    removerElementoDeLista<Clase>(this.instituto.clases, "clase");
                    break;
            }
        }

        /// <summary>
        /// Si la lista tiene mas de un elemento, preguntar si se quiere remover o no, si se acepta se remueve, sino se cancela.
        /// Si la lista no tiene elementos se notifica.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <param name="entidadString"></param>
        private void removerElementoDeLista<T>(List<T> lista, string entidadString) where T : class
        {
            if (lista.Count>0)
            {
                try
                {
                    T entidadSeleccionada;
                    entidadSeleccionada = (T)this.lbListado.SelectedItem;

                    DialogResult resultado = MessageBox.Show("¿Desea remover este " + entidadString + "?"
                        + Environment.NewLine + entidadSeleccionada.ToString(),
                        "Remover elemento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        if (lista.Contains(entidadSeleccionada))
                        {
                            lista.Remove(entidadSeleccionada);
                            cargarEnListBox<T>(lbListado, lista);
                            MessageBox.Show("Se ha removido al/la "+entidadString+" correctamente", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error al remover al/la " + entidadString, "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se encuentran " + entidadString + "s en la lista", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Llamar al serializador para intentar guardar el archivo, de ser posible o no, igualmente lo notifica una ventanita.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lista"></param>
        /// <param name="nombreArchivo"></param>
        private void guardarListaEntidadesXML<T>(List<T> lista, string nombreArchivo) where T : class
        {
            if (ClaseSerializadoraXML.serializarXML<T>(lista, nombreArchivo))
            {
                MessageBox.Show("Se ha guardado el archivo "+nombreArchivo+".xml", "Guardado exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error guardando el archivo " + nombreArchivo + ".xml", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}