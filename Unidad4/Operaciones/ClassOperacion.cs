using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    abstract class ClassOperacion
    {
        //Atributos
        private double valor1 = 0, valor2 = 0, resultados = 0;

        //Propiedades
        public double Valor1
        {
            set { valor1 = value; }
            get { return valor1; }
        }
        public double Valor2
        {
            set { valor2 = value; }
            get { return valor2; }
        }
        public double Resultados
        {
            set { resultados = value; }
            get { return resultados; }
        }

        //Contructor
        public ClassOperacion()
        {
            valor1 = 0;
            valor2 = 0;
        }

        //Método
        public abstract void Operaciones();
    }
}
