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
        public static void serializarXML<T>(List<T> lista, string nombreArchivo, string path) where T : class
        {
            string nombreArchivoConFormato = nombreArchivo + ".xml";

            if (Directory.Exists(path))
            {
                using (XmlTextWriter writer = new XmlTextWriter(path+nombreArchivoConFormato, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<T>));
                    serializador.Serialize(writer, lista);
                }
            }
            else
            {
                throw new ArchivoException(nombreArchivoConFormato);
            }
        }

        public static List<T> deserializarXML<T>(string nombreArchivo, string path)
        {
            List<T> listaDatosXML = new List<T>();
            string nombreArchivoConFormato = nombreArchivo + ".xml";

            if (Directory.Exists(path))
            {
                using (XmlTextReader reader = new XmlTextReader(path+nombreArchivoConFormato))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<T>));
                    listaDatosXML = (List<T>)serializador.Deserialize(reader);
                }
            }
            else
            {
                throw new ArchivoException(nombreArchivoConFormato);
            }
            return listaDatosXML;
        }
    }
}