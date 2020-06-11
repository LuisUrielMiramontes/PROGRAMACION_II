using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    abstract class ClassFiguras
    {
        //Atributos
        private double lado = 0, perimetro = 0, area = 0;

        //Propiedades
        public double Lado
        {
            set { lado = value; }
            get { return lado; }
        }
        public double Perimetro
        {
            set { perimetro = value; }
            get { return perimetro; }
        }
        public double Area
        {
            set { area = value; }
            get { return area; }
        }

        //Constructor
        public ClassFiguras()
        {
            lado = 0;
            perimetro = 0;
            area = 0;
        }

        //Métodos
        public abstract void Figuras();
    }
}
