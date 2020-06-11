using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrado
{
    class ClassCuadrado
    {
        //Atributos
        public int lado = 0;
        public int area = 0, perimetro = 0;

        //Método Área
        public void SacarArea()
        {
            area = lado * lado;
        }

        //Método Perimetro
        public void SacarPerimetro()
        {
            perimetro = lado * 4;
        }
    }
}
