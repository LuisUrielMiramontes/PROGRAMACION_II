using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Triangulo : ClassFiguras
    {
        //Atributos
        private double baseTriangulo = 0, altura = 0;

        //Propiedades
        public double BaseTriangulo
        {
            set { baseTriangulo = value; }
            get { return baseTriangulo; }
        }
        public double Altura
        {
            set { altura = value; }
            get { return altura; }
        }

        //Constructor
        public Triangulo()
        {
            baseTriangulo = 0;
            altura = 0;
        }

        //Método
        public override void Figuras()
        {
            Area = BaseTriangulo * Altura / 2;
            Perimetro = BaseTriangulo * 3;
        }
    }
}
