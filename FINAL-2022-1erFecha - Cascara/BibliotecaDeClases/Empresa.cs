using System;
using System.Collections.Generic;

namespace BibliotecaDeClases
{

    //DESARROLLAR

    public class Empresa
    {
        public event Action<bool> BusquedasRealizadas;
        List<Puesto> posicionesAbiertas;
        int cantPuestosACubrir;

        public List<Puesto> Posiciones { get => posicionesAbiertas; }

        public Empresa(int puestosACubrir)
        {
            this.cantPuestosACubrir = puestosACubrir;
            posicionesAbiertas = new List<Puesto>();
        }

        public List<Puesto> AbrirBusqueda()
        {
            posicionesAbiertas.Add(GeneradorDeDatos.GetUnPuesto);
            if (posicionesAbiertas.Count == cantPuestosACubrir)
                BusquedasRealizadas.Invoke(true);
            return posicionesAbiertas;
        }

    }
}
