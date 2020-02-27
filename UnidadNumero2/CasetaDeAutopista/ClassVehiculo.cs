using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasetaDeAutopista
{
    class ClassVehiculo
    {
        //Atributos
        public string tipo;
        public int cobro = 0;

        //Métodos
        public void Caseta()
        {
            switch (tipo)
            {
                case "Motociclista":
                    {
                        cobro = 50;
                        break;
                    }
                case "Automóvil":
                    {
                        cobro = 112;
                        break;
                    }
                case "Autobús":
                    {
                        cobro = 170;
                        break;
                    }
                case "Tráiler":
                    {
                        cobro = 250;
                        break;
                    }
            }
        }
    }
}
