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

namespace MenuPrincipalForm
{
    public partial class MenuPrincipal : Form
    {
        private Instituto instituto;
        private int listadoIndex;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.instituto = new Instituto("Escuelita de Artes Multimediales");
            Curso cr1 = new Curso("Programacion de Videojuegos", 6000, Modalidad.Virtual, Nivel.Basico);
            Curso cr2 = new Curso("Dibujo de Cómics", 4500, Modalidad.Presencial, Nivel.Basico);
            Profesor p1 = new Profesor("Manuel A.", "cptnmanu@gmail.com");
            Profesor p2 = new Profesor("Miguel S.", "elsantaarte@hotmail.com");
            Alumno a1 = new Alumno("Franco Sampietro", "francosampi@hotmail.com", 6000, Nacionalidad.Argentina, TipoDePago.TransferenciaBancaria);
            Alumno a2 = new Alumno("Kinoto Rodríguez", "kinotito@hotmail.com", 4500, Nacionalidad.Extranjera, TipoDePago.Tarjeta);
            Clase c1 = new Clase(p1,cr1,Dias.Lunes,Horario.Tarde);
            Clase c2 = new Clase(p2,cr2,Dias.Martes,Horario.Mañana);

            c1 += a1;
            c2 += a2;
            a1.curso = cr1;
            a2.curso = cr2;
            this.instituto.profesores.Add(p1);
            this.instituto.profesores.Add(p2);
            this.instituto.alumnos.Add(a1);
            this.instituto.alumnos.Add(a2);
            this.instituto.cursos.Add(cr1);
            this.instituto.cursos.Add(cr2);
            this.instituto += c1;
            this.instituto += c2;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.listadoIndex = 0;
            cargarEnListBox<Clase>(lbListado, this.instituto.clases);
        }

        private void cargarEnListBox<T>(ListBox lb, List<T> list) where T : class
        {
            lb.DataSource = null;
            lb.Items.Clear();
            lb.DataSource=list;
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
            lbListado.SelectedIndex = 0;
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            this.listadoIndex = 0;
            cargarEnListBox<Clase>(lbListado, this.instituto.clases);
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            this.listadoIndex = 1;
            cargarEnListBox<Profesor>(lbListado, this.instituto.profesores);
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.listadoIndex = 2;
            cargarEnListBox<Alumno>(lbListado, this.instituto.alumnos);
        }

        private void lbListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (this.listadoIndex)
                {
                    case 0:
                        escribirDetalleClase(tbDetalles);
                        break;
                    case 1:
                        escribirDetalleProfesor(tbDetalles);
                        break;
                    case 2:
                        escribirDetalleAlumno(tbDetalles);
                        break;
                }
            }
            catch (Exception ex)
            {
                tbDetalles.Text = ex.Message;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.listadoIndex==2)
            {
                Alumno alumnoNuevo = new Alumno();

                if (alumnoNuevo is not null)
                {
                    Form menuAgregar = new frmAgregar(alumnoNuevo, this.instituto.cursos);
                    DialogResult resultado = menuAgregar.ShowDialog();

                    if(resultado==DialogResult.OK)
                    {
                        this.instituto.alumnos.Add(alumnoNuevo);
                        cargarEnListBox<Alumno>(lbListado, this.instituto.alumnos);
                    }
                }
            }
        }
    }
}