using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JSON=System.Text.Json;
using Excepciones;

namespace SerializadorJSON
{
    public class SerializadorJSON
    {
        public static bool serializarJSON<T>(int tamano, string nombreArchivo)
        {
            T[] arreglo = new T[tamano];

            try
            {
                string objJson = JSON.JsonSerializer.Serialize(arreglo);
                return true;
            }
            catch (Exception)
            {
                throw new ArchivoException("No se pudo guardar el archivo");
            }
        }
    }
}