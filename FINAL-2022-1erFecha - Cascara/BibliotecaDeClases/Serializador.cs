using System;
using System.IO;
using System.Text.Json;

namespace BibliotecaDeClases
{


    // DESARROLLAR
    public static class Serializador<T>
    {
        public static void Escribir(T datos, string ruta, string nombreArchivo, Action<string> mostrarElementos)
        {
            JsonSerializerOptions opts = new JsonSerializerOptions();
            opts.WriteIndented = true;
            using (StreamWriter sw = new StreamWriter(Path.Combine(ruta, nombreArchivo), append: true))
            {
                var data = JsonSerializer.Serialize(datos, typeof(T), opts);
                sw.Write(data);
            }
            mostrarElementos("El Empleado ha sido serializado correctamente");
        }
      
    }
}
