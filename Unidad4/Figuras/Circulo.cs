using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Circulo : ClassFiguras
    {
        //Atributos
        private double radio = 0, circunferencia = 0;

        //Propiedades
        public double Radio
        {
            set { radio = value; }
            get { return radio; }
        }
        public double Circunferencia
        {
            set { circunferencia = value; }
            get { return circunferencia; }
        }

        //Constructor
        public Circulo()
        {
            radio = 0;
            circunferencia = 0;
        }

        //Método
        public override void Figuras()
        {
            Area = 3.1416 * (Radio*Radio);
            Perimetro = 6.2832 * Radio;
        }
    }
}
