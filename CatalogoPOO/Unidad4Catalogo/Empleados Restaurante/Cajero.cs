using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    class Cajero:ClassEmpleado
    {
        //Atributos
        private string numeroCaja;
        private double sueldoSemanal = 0;

        //Propiedades
        public string NumeroCaja
        {
            set {numeroCaja = value;}
            get {return numeroCaja;}
        }
        public double SueldoSemanal
        {
            set {sueldoSemanal = value;}
            get {return sueldoSemanal;}
        }

        //Constructor
        public Cajero()
        {
            numeroCaja = "";
        }

        //Método
        public override void CalcularSueldo()
        {
            if (NumeroCaja == "Caja 2")
            {
                SueldoSemanal = (sueldoSemanal * DiasTrabajados) + (sueldoSemanal * .3);
            }
            else if (NumeroCaja == "Caja 1")
            {
                SueldoSemanal = Sueldo * DiasTrabajados;
            }
        }
    }
}
