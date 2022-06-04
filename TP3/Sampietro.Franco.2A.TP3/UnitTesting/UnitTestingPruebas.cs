using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            Profesor p1 = new Profesor("Prueba", "Prueba@gmail.com");
            Profesor p2 = new Profesor("Prueba", "Prueba@gmail.com");

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
    }
}