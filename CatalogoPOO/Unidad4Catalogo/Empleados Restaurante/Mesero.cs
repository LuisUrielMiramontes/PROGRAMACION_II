using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    class Mesero : ClassEmpleado
    {
        //Atributos
        private double sueldoSemana = 0, propina = 0;

        //Propiedades
        public double SueldoSemana
        {
            set { sueldoSemana = value; }
            get { return sueldoSemana; }
        }
        public double Propina
        {
            set {propina = value;}
            get {return propina;}
        }

        //Constructor
        public Mesero()
        {
            sueldoSemana = 0;
            propina = 0;
        }

        //Método
        public override void CalcularSueldo()
        {
            SueldoSemana = (Sueldo * DiasTrabajados) + Propina;
        }
    }
}
