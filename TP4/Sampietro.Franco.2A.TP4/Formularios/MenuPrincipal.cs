using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using MenuAgregarForm;
using MenuAgregarProfesorForm;
using SerializadorXML;
using SerializadorJSON;
using Excepciones;
using System.Text;
using System.IO;
using Formularios;
using static Entidades.Delegados;

namespace MenuPrincipalForm
{
    public partial class MenuPrincipal : Form
    {
        private Instituto instituto;
        private int listadoIndex;
        private bool huboCambios;
        private readonly string path = "..\\..\\..\\..\\Archivos\\";
        private readonly string nombreArchivoListaAlumnos = "ListaDeAlumnos";
        private readonly string nombreArchivoListaProfesores = "ListaDeProfesores";
        private readonly string nombreArchivoListaClases = "CronogramaDeClases";
        private readonly string nombreArchivoConfiguracion = "configuracion";
        private int[] configuracion = new int[] {0, -1};

        /// <summary>
        /// Inicializar instituto con nombre, cargar cursos disponibles, y traer de los archivos xml: alumnos, profesores y clases que se dan.
        /// luego trae la configuracion de la sesión anterior (si estaba o no en modo oscuro, y la lista que se haya estado mostrando)
        /// </summary>
        public MenuPrincipal()
        {
            InitializeComponent();
            this.instituto = new Instituto("Da Vinci");

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

            Profesor p1 = new Profesor("Manuel A", "cptnmanu@gmail.com", cr1);
            Profesor p2 = new Profesor("Miguel S", "elsantaarte@hotmail.com", cr2);
            Profesor p3 = new Profesor("Lucas V", "luquitasdr@gmail.com", cr3);
            Profesor p4 = new Profesor("Micaela T", "mtdvinc@gmail.com", cr4);
            Profesor p5 = new Profesor("Carolina S", "caroutn@gmail.com", cr5);

            Clase cl1 = new Clase(p1, Dias.Lunes, Horario.Mañana);
            Clase cl2 = new Clase(p2, Dias.Martes, Horario.Mañana);
            Clase cl3 = new Clase(p3, Dias.Miercoles, Horario.Tarde);
            Clase cl4 = new Clase(p4, Dias.Jueves, Horario.Mañana);
            Clase cl5 = new Clase(p5, Dias.Viernes, Horario.Tarde);

            this.instituto.clases.Add(cl1); 
            this.instituto.clases.Add(cl2);
            this.instituto.clases.Add(cl3);
            this.instituto.clases.Add(cl4);
            this.instituto.clases.Add(cl5);

            try
            {
                this.instituto.alumnos = ClaseSerializadoraXML.deserializarXML<Alumno>(this.nombreArchivoListaAlumnos, this.path);
                this.instituto.profesores = ClaseSerializadoraXML.deserializarXML<Profesor>(this.nombreArchivoListaProfesores, this.path);
                this.configuracion = ClaseSerializadoraJSON.deserializarJSON<int[]>(this.nombreArchivoConfiguracion, this.path);
            }
            catch(ArchivoException e)
            {
                MessageBox.Show("Ocurrio un error abriendo el archivo "+e.Message, "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Por defecto el formulario cargará la lista que estuvo cargada la ultima vez que saliste de la aplicación.
        /// Si es la primera vez que se abre, aparece la pestaña Alumnos abierta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.listadoIndex = this.configuracion[0];
            switch(this.listadoIndex)
            {
                case 0:
                    cargarEnListBox<Alumno>(lbListado, this.instituto.alumnos, btnAlumnos.Select);
                    break;
                case 1:
                    cargarEnListBox<Profesor>(lbListado, this.instituto.profesores, btnProfesores.Select);
                    break;
                case 2:
                    cargarEnListBox<Clase>(lbListado, this.instituto.clases, btnClases.Select);
                    break;
            }
            this.huboCambios = false;
            cambiarColorModo(this.configuracion[1]);
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
                    lb.Items.Add(item).ToString();
                }
            }
            catch (ArgumentException ex)
            {
                tbDetalles.Text = ex.Message;
            }

            if (lbListado.Items.Count!=0)
            {
                lbListado.SelectedIndex = 0;
            }
        }

        private void cargarEnListBox<T>(ListBox lb, List<T> list, Action action) where T : class
        {
            cargarEnListBox(lb, list);
            action.Invoke();
        }

        /// <summary>
        /// click en los botones de arriba para cargar su lista en la listbox.
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
        /// Al cambiar de item seleccionado de cada una de las listas, mostrar su detalle a la derecha.
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
                        escribirDetalleAlumno(this.lbListado, this.tbDetalles, escribirDetalle);
                        btnGuardarXML.Text = "Guardar Alumnos en XML";
                        break;
                    case 1:
                        escribirDetalleProfesor(this.lbListado, this.tbDetalles, escribirDetalle);
                        btnGuardarXML.Text = "Guardar Profesores en XML";
                        break;
                    case 2:
                        escribirDetalleClase(this.lbListado, this.tbDetalles, escribirDetalle);
                        btnGuardarXML.Text = "Guardar cronograma de clases";
                        break;
                }
                this.configuracion[0] = this.listadoIndex;
            }
            catch (Exception ex)
            {
                tbDetalles.Text = ex.Message;
            }
        }

        /// <summary>
        /// recibe un objeto y, si no es nulo, invoca su ficha de un delegado para guardarla en un textbox
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entidad"></param>
        /// <param name="tb"></param>
        /// <param name="ficha"></param>
        public void escribirDetalle<T>(T entidad, TextBox tb, delegadoFicha ficha)
        {
            if (entidad is not null)
            { 
                tb.Text = ficha.Invoke();
            }
        }

        /// <summary>
        /// Escribir en textbox los detalles de cada entidad.
        /// </summary>
        /// <param name="tb"></param>
        private void escribirDetalleAlumno(ListBox lb, TextBox tb, delegadoDetalles delegado)
        {
            Alumno alumnoSeleccionado = (Alumno)lb.SelectedItem;

            delegado(alumnoSeleccionado, tb, alumnoSeleccionado.Ficha);
        }

        private void escribirDetalleProfesor(ListBox lb, TextBox tb, delegadoDetalles delegado)
        {
            Profesor profesorSeleccionado = (Profesor)lb.SelectedItem;

            delegado(profesorSeleccionado, tb, profesorSeleccionado.Ficha);
        }

        private void escribirDetalleClase(ListBox lb, TextBox tb, delegadoDetalles delegado)
        {
            Clase claseSeleccionada = (Clase)lb.SelectedItem;

            delegado(claseSeleccionada, tb, claseSeleccionada.Ficha);
        }


        /// <summary>
        /// Segun sea la lista que se muestra, llamar al menu de agregar correspondiente, de ser un registro correcto, agregar entidad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            switch (this.listadoIndex)
            {
                case 0:
                    Alumno alumnoNuevo = new Alumno();

                    Form menuAlumno = new frmMenuAlumno(alumnoNuevo, this.instituto.cursos, FormAccion.Agregar);
                    resultado = menuAlumno.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        try
                        {
                            this.instituto+=alumnoNuevo;
                            cargarEnListBox<Alumno>(lbListado, this.instituto.alumnos);
                            this.huboCambios = true;
                            MessageBox.Show("Se ha cargado al alumno correctamente", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch(AlumnoInscriptoRepetidoException)
                        {
                            MessageBox.Show("Ya existe ese alumno en la base de datos", "Alumno repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    break;
                case 1:
                    Profesor profesorNuevo = new Profesor();

                    Form menuProfesor = new frmMenuProfesor(profesorNuevo, this.instituto.cursos, FormAccion.Agregar);
                    resultado = menuProfesor.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        try
                        {
                            this.instituto+=profesorNuevo;
                            cargarEnListBox<Profesor>(lbListado, this.instituto.profesores);
                            this.huboCambios = true;
                            MessageBox.Show("Se ha cargado al profesor correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch(ProfesorContratadoRepetidoException)
                        {
                            MessageBox.Show("Ya existe ese profesor en la base de datos", "Profesor repetido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    break;
                case 2:
                    Clase claseNueva = new Clase();

                    Form menuClase = new frmMenuClase(claseNueva, this.instituto.profesores, FormAccion.Agregar);
                    resultado = menuClase.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        try
                        {
                            this.instituto+=claseNueva;
                            cargarEnListBox<Clase>(lbListado, this.instituto.clases);
                            this.huboCambios = true;
                            MessageBox.Show("Se ha cargado la clase correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch(ClaseRepetidaException)
                        {
                            MessageBox.Show("Ya existe esa clase en la base de datos", "Clase repetida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    if (this.instituto.alumnos.Count > 0)
                    {
                        Alumno alumnoSeleccionado = (Alumno)this.lbListado.SelectedItem;
                        Alumno alumnoManejador = alumnoSeleccionado;

                        Form menuAlumno = new frmMenuAlumno(alumnoManejador, this.instituto.cursos, FormAccion.Modificar);
                        DialogResult resultado = menuAlumno.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            alumnoSeleccionado = alumnoManejador;
                            this.huboCambios = true;
                            cargarEnListBox<Alumno>(lbListado, this.instituto.alumnos);
                            MessageBox.Show("Se ha modificado al alumno correctamente\n(" + alumnoSeleccionado.nombre + ")", "Alta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encuentran elementos en la lista", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 1:
                    if (this.instituto.profesores.Count > 0)
                    {
                        Profesor profesorSeleccionado = (Profesor)this.lbListado.SelectedItem;
                        Profesor profesorManejador = profesorSeleccionado;

                        Form menuProfesor = new frmMenuProfesor(profesorManejador, this.instituto.cursos, FormAccion.Modificar);
                        DialogResult resultado = menuProfesor.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            profesorSeleccionado = profesorManejador;
                            this.huboCambios = true;
                            cargarEnListBox<Profesor>(lbListado, this.instituto.profesores);
                            MessageBox.Show("Se ha modificado al profesor correctamente\n(" + profesorSeleccionado.nombre + ")", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encuentran elementos en la lista", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case 2:
                    if (this.instituto.clases.Count > 0)
                    {
                        Clase claseSeleccionada = (Clase)this.lbListado.SelectedItem;
                        Clase claseManejadora = claseSeleccionada;

                        Form menuClase = new frmMenuClase(claseManejadora, this.instituto.profesores, FormAccion.Modificar);
                        DialogResult resultado = menuClase.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            claseSeleccionada = claseManejadora;
                            this.huboCambios = true;
                            cargarEnListBox<Clase>(lbListado, this.instituto.clases);
                            MessageBox.Show("Se ha modificado la clase correctamente\n(" + claseSeleccionada.profesor.curso.ToString() + ")", "Modificacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encuentran elementos en la lista", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        /// <summary>
        /// Click en remover para, si hay una entidad seleccionada, removerla de su lista correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
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
            catch(ListaVaciaException)
            {
                MessageBox.Show("No se puede remover de una lista vacía", "Lista vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    StringBuilder sb = new StringBuilder();
                    foreach (Clase clase in this.instituto.clases)
                    {
                        sb.AppendLine(clase.dias.ToString() + ": " + clase.ToString());
                    }
                    File.WriteAllText(this.path + nombreArchivoListaClases+".txt", sb.ToString());
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
                        this.huboCambios = true;
                        MessageBox.Show("Se ha removido al/la "+entidadString+" correctamente", "Baja exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                throw new ListaVaciaException();
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
            try
            {
                ClaseSerializadoraXML.serializarXML<T>(lista, nombreArchivo, this.path);
                MessageBox.Show("Se ha guardado el archivo " + nombreArchivo + ".xml", "Guardado exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.huboCambios = false;
            }
            catch(ArchivoException)
            {
                MessageBox.Show("Ocurrio un error guardando el archivo " + nombreArchivo + ".xml", "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Al estar cerrandose, llamar funcion que verificara que el usuario quiera salir.
        /// Si el usuario decide cerrar la aplicacion, se guardara la configuracion, que consta de la ultima lista mostrada, y el modo del color del form (oscuro o no)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrarForm())
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    ClaseSerializadoraJSON.serializarArregloJSON<int[]>(this.configuracion, this.nombreArchivoConfiguracion, this.path);
                }
                catch(ArchivoException)
                {
                    MessageBox.Show("Ocurrio un error abriendo el archivo " + this.nombreArchivoConfiguracion, "Ouch!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Si hubo cambios sin guardar en la aplicacion, saldra un warning, sino se cierra normalmente.
        /// </summary>
        /// <returns></returns>
        private bool cerrarForm()
        {
            if (this.huboCambios)
            {
                DialogResult resultado = MessageBox.Show("Hay cambios sin guardar, ¿Salir igualmente?", "Cerrando aplicación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (resultado != DialogResult.Yes)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnModoOscuro_Click(object sender, EventArgs e)
        {
            this.configuracion[1] = -this.configuracion[1];
            cambiarColorModo(this.configuracion[1]);
        }

        /// <summary>
        /// Colorear formulario segun modo, y cambiar el modo
        /// </summary>
        /// <param name="modoActual"></param>
        /// <returns></returns>
        private void cambiarColorModo(int modoActual)
        {
            if (modoActual==1)
            {
                this.BackColor = Color.Black;
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.BackColor = Color.DarkBlue;
                    button.ForeColor = Color.White;
                }
                tbDetalles.BackColor = Color.Blue;
                tbDetalles.ForeColor = Color.White;
                lbListado.BackColor = Color.DarkBlue;
                lbListado.ForeColor = Color.White;
                lblDetalles.ForeColor = Color.White;
                pbLogoInstituto.BackgroundImage = Formularios.Properties.Resources.davinci02;
                btnModoOscuro.BackgroundImage = Formularios.Properties.Resources.modoOscuro02;
            }
            else
            {
                this.BackColor = SystemColors.ActiveBorder;
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.BackColor = SystemColors.ControlLight;
                    button.ForeColor = Color.Black;
                }
                btnRemover.BackColor = Color.LightCoral;
                tbDetalles.BackColor = SystemColors.Window;
                tbDetalles.ForeColor = Color.Black;
                lbListado.BackColor = SystemColors.Window;
                lbListado.ForeColor = Color.Black;
                lblDetalles.ForeColor = Color.Black;
                pbLogoInstituto.BackgroundImage = Formularios.Properties.Resources.davinci01;
                btnModoOscuro.BackgroundImage = Formularios.Properties.Resources.modoOscuro01;
            }
        }

        private void btnPlanillaNotas_Click(object sender, EventArgs e)
        {
            Form menuClase = new frmPlanillaNotas();
        }
    }
}