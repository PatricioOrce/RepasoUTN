using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaDeClases
{

    // DESARROLLAR
    public class SqlManejador
    {
        SqlCommand comando;
        SqlConnection conexion;
        public SqlManejador()
        {
        }
        public int Insertar(EmpleadoFreelance dato)
        {
            //     protected decimal dni;
            //protected string nombreCompleto;
            //protected string posicion;
            //protected int remuneracionPretendida;
            try
            {
                conexion = new SqlConnection("Server=DESKTOP-7S0MC1J\\SQLEXPRESS;Database=ExamenPrimerFecha2022;Trusted_Connection=True;");
                conexion.Open();
                string query = "INSERT INTO Empleados VALUES (@dni, @nombre, @posicion, @honorario)";
                comando = new SqlCommand(query, conexion);
                if (dato.Dni < 10000000 || dato.Dni > 45000000 || string.IsNullOrEmpty(dato.NombreCompleto))
                    throw new DatoErroneoException("Valor Incorrecto");
                comando.Parameters.AddWithValue("dni", dato.Dni);
                comando.Parameters.AddWithValue("nombre", dato.NombreCompleto);
                comando.Parameters.AddWithValue("posicion", dato.Posicion);
                comando.Parameters.AddWithValue("honorario", dato.CalcularCompensacion);
                return comando.ExecuteNonQuery();
            }
            catch (DatoErroneoException ex)
            {
                throw;
            }
            finally { conexion.Close(); }
        }
    }
}
