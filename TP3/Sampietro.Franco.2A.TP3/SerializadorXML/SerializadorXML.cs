using Excepciones;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerializadorXML
{
    public static class ClaseSerializadoraXML
    {
        public static void serializarXML<T>(List<T> lista, string nombreArchivo) where T : class
        {
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter("..\\..\\..\\..\\" + nombreArchivo + ".xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<T>));
                    serializador.Serialize(writer, lista);
                }
            }
            catch (ArchivoException)
            {
                throw new ArchivoException();
            }
        }

        public static List<T> deserializarXML<T>(string nombreArchivo)
        {
            List<T> listaDatosXML = new List<T>();

            try
            {
                using (XmlTextReader reader = new XmlTextReader("..\\..\\..\\..\\" + nombreArchivo + ".xml"))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<T>));
                    listaDatosXML = (List<T>)serializador.Deserialize(reader);
                }
            }
            catch (ArchivoException)
            {
                throw new ArchivoException();
            }
            return listaDatosXML;
        }
    }
}