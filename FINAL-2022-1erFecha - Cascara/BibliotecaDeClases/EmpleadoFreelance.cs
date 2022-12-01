using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{

    //DESARROLLAR
    public class EmpleadoFreelance : Empleado
    {
        bool dolarOficial;

        public EmpleadoFreelance(decimal dni, string nombre, string posicion, bool dolarOficial) : base(dni, nombre, posicion)
        {
            this.dolarOficial = dolarOficial;
        }

        public override float CalcularCompensacion
        {
            get
            {
                if (dolarOficial)
                    return base.remuneracionPretendida / 138;
                else
                    return base.remuneracionPretendida / 290;
            }
        }
    }
}
