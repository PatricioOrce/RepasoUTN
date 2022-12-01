using System;

namespace BibliotecaDeClases
{
    //DESARROLLAR 
    public abstract class Empleado : ICompensacion
    {
        protected decimal dni;
        protected string nombreCompleto;
        protected string posicion;
        protected int remuneracionPretendida;

        protected Empleado()
        {
            remuneracionPretendida = GeneradorDeDatos.Rnd.Next(100000, 250000);
        }
        public Empleado(decimal dni, string nombre, string posicion) : this() 
        {
            this.dni = dni;
            this.nombreCompleto = nombre;
            this.posicion = posicion;

        }

        public string Posicion
        {
            get { return posicion; }
        }
        public abstract float CalcularCompensacion { get; }
        public decimal Dni { get => dni; set => dni = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }

    }
}
