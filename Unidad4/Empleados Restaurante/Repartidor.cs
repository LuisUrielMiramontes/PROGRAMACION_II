using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    class Repartidor : ClassEmpleado
    {
        //Atributos
        private double propinaSemana = 0, sueldoRep = 0;
        private string zonaReparto;
        private int totalAbonos = 0;

        //Propiedades
        public double PropinaSemana
        {
            set {propinaSemana = value;}
            get {return propinaSemana;}
        }
        public string ZonaReparto
        {
            set {zonaReparto = value;}
            get {return zonaReparto;}
        }
        public int TotalAbonos
        {
            set {totalAbonos = value;}
            get {return totalAbonos;}
        }
        public double SueldoRep
        {
            set { sueldoRep = value; }
            get { return sueldoRep; }
        }
        //Constructor
        public Repartidor()
        {
            sueldoRep = 0;
            propinaSemana = 0;
            zonaReparto = "";
            totalAbonos = 0;
        }

        //Método
        public override void CalcularSueldo()
        {
            if (zonaReparto == "Zona 1")
            {
                SueldoRep = Sueldo * (DiasTrabajados + 5);
            }
            else if (zonaReparto == "Zona 2")
            {
                SueldoRep = Sueldo * (DiasTrabajados + 2);
            }
        }
    }
}
