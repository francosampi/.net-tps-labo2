using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
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
            catch(Exception)
            {
                throw new ArchivoException("No se pudo serializar JSON");
            }
        }
    }
}