using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    class ClassTemperatura
    {
        //Atributos
        public string tipo, resultado;
        public double grado = 0;

        //Métodos
        public void ConvertirCelsius()
        {
            switch (tipo)
            {
                case "Fahrenheit":
                    {
                        grado = (grado - 32) * 5 / 9;
                        resultado = "°Centigrados";
                        break;
                    }
            }
        }
        public void ConvertirFahrenheit()
        {
            switch (tipo)
            {
                case "Celsius":
                    {
                        grado = (grado * 9 / 5) + 32;
                        resultado = "°Fahrenheit";
                        break;
                    }
            }
        }
    }
}
