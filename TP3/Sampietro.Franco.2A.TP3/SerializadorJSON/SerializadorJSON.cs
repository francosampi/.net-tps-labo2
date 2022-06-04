using System;
using System.Text.Json;
using Excepciones;
using System.IO;

namespace SerializadorJSON
{
    public static class ClaseSerializadoraJSON
    {
        public static void serializarArregloJSON<T>(T dato, string nombreArchivo)
        {
            string path = "..\\..\\..\\..\\";
            string nombreArchivoConFormato = path + nombreArchivo + ".json";

            if (File.Exists(nombreArchivoConFormato))
            {
                string datoAJSon = JsonSerializer.Serialize(dato);
                File.WriteAllText(nombreArchivoConFormato, datoAJSon);
            }
            else
            {
                throw new ArchivoException();
            }
        }

        public static T deserializarJSON<T>(string nombreArchivo)
        {
            string path = "..\\..\\..\\..\\";
            string nombreArchivoConFormato = path + nombreArchivo + ".json";

            if (File.Exists(nombreArchivoConFormato))
            {
                using (StreamReader sr = new StreamReader(nombreArchivoConFormato))
                {
                    string JSONString = sr.ReadToEnd();
                    return (T)JsonSerializer.Deserialize(JSONString, typeof(T));
                }
            }
            else
            {
                throw new ArchivoException();
            }
        }
    }
}