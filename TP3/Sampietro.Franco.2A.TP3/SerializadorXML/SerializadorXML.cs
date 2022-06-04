using Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerializadorXML
{
    public static class ClaseSerializadoraXML
    {
        public static void serializarXML<T>(List<T> lista, string nombreArchivo) where T : class
        {
            string path = "..\\..\\..\\..\\";
            string nombreArchivoConFormato = path + nombreArchivo + ".xml";

            if (File.Exists(nombreArchivoConFormato))
            {
                using (XmlTextWriter writer = new XmlTextWriter(nombreArchivoConFormato, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<T>));
                    serializador.Serialize(writer, lista);
                }
            }
            else
            {
                throw new ArchivoException();
            }
        }

        public static List<T> deserializarXML<T>(string nombreArchivo)
        {
            List<T> listaDatosXML = new List<T>();

            string path = "..\\..\\..\\..\\";
            string nombreArchivoConFormato = path + nombreArchivo + ".xml";

            if (File.Exists(nombreArchivoConFormato))
            {
                using (XmlTextReader reader = new XmlTextReader(nombreArchivoConFormato))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<T>));
                    listaDatosXML = (List<T>)serializador.Deserialize(reader);
                }
            }
            else
            {
                throw new ArchivoException();
            }
            return listaDatosXML;
        }
    }
}