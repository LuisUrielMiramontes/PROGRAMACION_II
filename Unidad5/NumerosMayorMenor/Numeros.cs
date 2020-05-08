using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosMayorMenor
{
    class Numeros
    {
        public int mayor { set; get; }
        public int menor { set; get; }
        public int ingresarNumeros { set; get; }
        public int[] arregloNumeros { set; get; }
        public string SacarMayorMenor()
        {
            string Resultado = "";
            mayor = -99999;
            menor = 99999;
            for (int f = 0; f < arregloNumeros.Length; f++)
            {
                if (arregloNumeros[f] > mayor)
                {
                    mayor = arregloNumeros[f];
                }
                else if (arregloNumeros[f] < menor)
                {
                    menor = arregloNumeros[f];
                }
            }
            Resultado = "El mayor es: " + mayor + " El menor es: " + menor;            
            return Resultado;
        }
    }
}
