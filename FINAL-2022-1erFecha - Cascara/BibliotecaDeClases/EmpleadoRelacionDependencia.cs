using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{

    public enum EBono
    {
        Basico = 15000,
        Medio = 25000,
        Alto = 40000
    }


    // DESARROLLAR
    public class EmpleadoRelacionDependencia : Empleado
    {

        EBono bono;

        public EmpleadoRelacionDependencia(decimal dni, string nombreCompleto, string posicion, EBono bono)
        {
            this.bono = bono;
        }

        public override float CalcularCompensacion
        {
            get
            {
                if (remuneracionPretendida > 250000)
                    return remuneracionPretendida * 0.70f;
                else
                    return remuneracionPretendida;
            }
        }
        public float SueldoConAguinaldoActualizado { get 
            {
                return (remuneracionPretendida * 1.50f) + (int)bono;
            } 
        }
    }
}
