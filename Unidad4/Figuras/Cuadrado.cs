using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    class Cuadrado:ClassFiguras
    {
        //Método
        public override void Figuras()
        {
            Area = Lado * Lado;
            Perimetro = Lado * 4;
        }
    }
}
