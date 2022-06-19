using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UnitTesting
{
    [TestClass]
    public class UnitTestingPruebas
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoInscriptoRepetidoException))]
        public void SiUnAlumnoInscriptoSeRepite_DeberiaRetornarExcepcion()
        {
            Instituto instituto = new Instituto("Prueba");
            Alumno a1 = new Alumno("Prueba", "Prueba@gmail.com", 1000, Nacionalidad.Argentina, TipoDePago.Tarjeta);
            Alumno a2 = new Alumno("Prueba", "Prueba@gmail.com", 1001, Nacionalidad.Argentina, TipoDePago.Tarjeta);

            instituto += a1;
            instituto += a2;
        }

        [TestMethod]
        [ExpectedException(typeof(ProfesorContratadoRepetidoException))]
        public void SiUnProfesorContratadoSeRepite_DeberiaRetornarExcepcion()
        {
            Instituto instituto = new Instituto("Prueba");
            Curso c1 = new Curso();
            Profesor p1 = new Profesor("Prueba", "Prueba@gmail.com", c1);
            Profesor p2 = new Profesor("Prueba", "Prueba@gmail.com", c1);

            instituto += p1;
            instituto += p2;
        }

        [TestMethod]
        public void SiUnNombreTieneCaracteresInvalidos_DeberiaRetornarFalse()
        {
            Regex regex = new Regex(@"^[a-zA-Zá-úÁ-Ú ]*$");
            string nombre = "¡abc1234";

            Assert.IsFalse(regex.IsMatch(nombre));
        }

        [TestMethod]
        [ExpectedException(typeof(AlumnoInscriptoRepetidoException))]
        public void SiUnAlumnoAnotadoEnClaseSeRepite_DeberiaRetornarExcepcion()
        {
            Profesor profe = new Profesor();
            Clase clase = new Clase(profe, Dias.Lunes, Horario.Mañana);
            Alumno a1 = new Alumno("Prueba", "Prueba@gmail.com", 1000, Nacionalidad.Argentina, TipoDePago.Tarjeta);

            clase += a1;
            clase += a1;
        }

        [TestMethod]
        [ExpectedException(typeof(ClaseRepetidaException))]
        public void SiYaExisteLaClaseEnElInstituto_DeberiaRetornarExcepcion()
        {
            Instituto instituto = new Instituto("Prueba");
            Profesor profe = new Profesor();
            Clase clase = new Clase(profe, Dias.Lunes, Horario.Mañana);

            instituto += clase;
            instituto += clase;
        }

        //[TestMethod]
        //public void SiUnaCeldaTieneCaracteresInvalidos_DeberiaRetornarFalse()
        //{
        //    string[] rowString = { "@", "-" };
        //    DataGridView dg = new DataGridView();
        //    dg.Rows.Add(rowString);

        //    Assert.IsFalse(dg.Rows[0].soloDigitosEnCelda(0));
        //}
    }
}