using System;
using System.Text.Json;
using Excepciones;
using System.IO;

namespace SerializadorJSON
{
    public static class ClaseSerializadoraJSON
    {
        public static bool serializarArregloJSON<T>(T dato, string nombreArchivo)
        {
            try
            {
                string path = "..\\..\\..\\..\\";
                string nombreArchivoConFormato = path + nombreArchivo + ".json";
                string datoAJSon = JsonSerializer.Serialize(dato);
                File.WriteAllText(nombreArchivoConFormato, datoAJSon);

                return true;
            }
            catch(ArchivoException)
            {
                throw new ArchivoException("No se pudo serializar JSON");
            }
        }

        public static T deserializarJSON<T>(string nombreArchivo)
        {
            try
            {
                string path = "..\\..\\..\\..\\";
                string nombreArchivoConFormato = path + nombreArchivo + ".json";

                using (StreamReader sr = new StreamReader(nombreArchivoConFormato))
                {
                    string JSONString = sr.ReadToEnd();
                    return (T)JsonSerializer.Deserialize(JSONString, typeof(T));
                }
            }
            catch(ArchivoException)
            {
                throw new ArchivoException("No se pudo deserializar JSON");
            }
        }
    }
}