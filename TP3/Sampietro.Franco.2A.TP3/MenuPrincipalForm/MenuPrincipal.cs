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

namespace MenuPrincipalForm
{
    public partial class MenuPrincipal : Form
    {
        private Instituto instituto;
        private List<Alumno> alumnos;

        public MenuPrincipal()
        {
            InitializeComponent();
            this.instituto = new Instituto("Escuelita Multimedia");
            Profesor p1 = new Profesor("Manuel A.", "cptnmanu@hotmail.com");
            Alumno a1 = new Alumno("Franco Sampietro", "francosampi@hotmail.com", Nacionalidad.Argentina, TipoDePago.TransferenciaBancaria);
            Alumno a2 = new Alumno("Kinoto", "kinotito@hotmail.com", Nacionalidad.Extranjera, TipoDePago.Tarjeta);
            Curso cr1 = new Curso("Programacion de Videojuegos", 6000, Modalidad.Virtual, Nivel.Basico);

            Clase c1 = new Clase(p1,cr1,Dias.Lunes,Horario.Tarde);
            c1 += a1;
            c1 += a2;

            this.instituto += c1;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            cargarEnListBox<Clase>(lbListado, this.instituto.clases); 
        }

        private void cargarEnListBox<T>(ListBox lb, List<T> list) where T : class
        {
            foreach (T item in list)
            {
                lb.Items.Add((T)item).ToString();
            }
        }
    }
}
