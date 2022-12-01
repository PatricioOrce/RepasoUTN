using System;
using System.Collections.Generic;

namespace BibliotecaDeClases
{
    public static class GeneradorDeDatos
    {
        static Random rnd;
        static List<string> nombres;
        static List<string> apellidos;
        static List<string> puesto;
        static GeneradorDeDatos()
        {
            rnd = new Random();
            nombres = new List<string>()
            {
                "Sheffy",
                "Sibeal",
                "Fabiano",
                "Ethan",
                "Ethelyn",
                "Jarrod",
                "Meriel",
                "Gabie",
                "Gage",
                "Elena",
                "Kinna",
                "Monty",
                "Ashleigh",
                "Mira",
                "Martguerita",
                "Evelyn",
                "Bram",
                "Corissa",
                "Alayne",
                "Renado"
            };
            apellidos = new List<string>()
            {

                "Segrave",
                "McQuode",
                "Kilfedder",
                "Ygo",
                "Braniff",
                "Caulfield",
                "Keilloh",
                "Sudlow",
                "Rassmann",
                "Billison",
                "Darrach",
                "Glastonbury",
                "Tumber",
                "Pentercost",
                "Ruggs",
                "Beazley"
            };
            puesto = new List<string>()
            {
                "Desarrollador de videojuegos",
                "Diseñador UX/UI",
                "Artista 3D",
                "Lider tecnico"
            };
        }

        public static Random Rnd { get => rnd; }

        public static Empleado GetEmpleadoAleatorio
        {
            get
            {
                decimal dni = rnd.Next(10000000, 45000000);
                string nombreCompleto = $"{apellidos[rnd.Next(0, apellidos.Count)]},{nombres[rnd.Next(0, nombres.Count)]}";

                if (DevolverBoleanoAleatorio)
                    return new EmpleadoFreelance(dni, nombreCompleto, puesto[rnd.Next(0, puesto.Count)], DevolverBoleanoAleatorio);
                else
                    return new EmpleadoRelacionDependencia(dni, nombreCompleto, puesto[rnd.Next(0, puesto.Count)], EBono.Medio);

            }
        }

        private static bool DevolverBoleanoAleatorio
        {
            get { return rnd.Next(2) == 1; }
        }

        public static Puesto GetUnPuesto
        {
            get { return new Puesto(puesto[rnd.Next(0, puesto.Count)]); }
        }

    }
}
