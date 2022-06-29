using System;
using System.Text.Json;
using Excepciones;
using System.IO;

namespace SerializadorJSON
{
    public static class ClaseSerializadoraJSON
    {
        public static void serializarArregloJSON<T>(T dato, string nombreArchivo, string path)
        {
            string nombreArchivoConFormato = nombreArchivo + ".json";

            if (Directory.Exists(path))
            {
                string datoAJSon = JsonSerializer.Serialize(dato);
                File.WriteAllText(path+nombreArchivoConFormato, datoAJSon);
            }
            else
            {
                throw new ArchivoException(nombreArchivoConFormato);
            }
        }

        public static T deserializarJSON<T>(string nombreArchivo, string path)
        {
            string nombreArchivoConFormato = nombreArchivo + ".json";

            if (Directory.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path+nombreArchivoConFormato))
                {
                    string JSONString = sr.ReadToEnd();
                    return (T)JsonSerializer.Deserialize(JSONString, typeof(T));
                }
            }
            else
            {
                throw new ArchivoException(nombreArchivoConFormato);
            }
        }
    }
}