namespace BibliotecaDeClases
{

    // DESARROLLAR
    public class Puesto : ICompensacion
    {
        string nombrePuesto;
        float remuneraciónOfrecida;

        private Puesto()
        {
            remuneraciónOfrecida = GeneradorDeDatos.Rnd.Next(100000, 300000);
        }

        public Puesto(string nombre) : this()
        {
            this.nombrePuesto = nombre;
        }

        public string Posicion { get => nombrePuesto; }

        public float CalcularHonorarios
        {
            get
            {
                return remuneraciónOfrecida;
            }
        }

        public float CalcularCompensacion => remuneraciónOfrecida;

        public override string ToString()
        {
            return "Se busca "+ this.nombrePuesto + " - " + "Sueldo ofrecido: " + CalcularHonorarios.ToString();
        }
    }
}
