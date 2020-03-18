using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class ClassVehiculo
    {
        //Atributos
        public string combustible, color;
        public int numeroLlantas = 0, numeroPuertas = 0, numeroVentanas = 0;

        /*Constructor de la clase, es un método que se llama
        igual que la clase y se ejecuta automaticamente al crear el objeto*/
        public void Vehiculo()
        {
            combustible = "";
            color = "Blanco";
            numeroLlantas = 1;
            numeroPuertas = 0;
            numeroVentanas = 0;
        }
        public string ArranacarMotor (string Sonido)
        {
            return "Se arrancó el motor" + Sonido;
        }
        public string PararMotor (string Sonido)
        {
            return "Se detuvó el motor" + Sonido;
        }
    }
}
