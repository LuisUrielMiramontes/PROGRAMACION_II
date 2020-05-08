using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizSumaFCD
{
    class MatrizFCD
    {
        //Estas propiedes se crean aquí para despues heredarlas al "Forms1.cs"
        public int [,] arregloMatriz { set; get; }
        public int filas { set; get; }
        public int[] acumFilas { set; get; }
        public int columnas { set; get; }
        public int[] acumColumnas { set; get; }
        public int diagonal { set; get; }
        public int[] acumDiagonal { set; get; }
        /*Este método sirve para poder sumar los datos acumulados de la fila de la matriz*/
        public void SumarFilas()
        {
            int f = 0;
            for (int i = 0; i < arregloMatriz.GetLength(0); i++)
            {
                int suma = 0;
                int acum = 0;
                for (int j = 1; j < arregloMatriz.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(arregloMatriz[i, j]);
                    acum += suma;
                }
                acumFilas[f] = acum;
                f++;
            }
        }
        /*Este método sirve para poder sumar los datos acumulados de la columna de la matriz*/
        public void SumarColumnas()
        {
            int c = 0;
            for (int i = 0; i < arregloMatriz.GetLength(0); i++)
            {
                int suma = 0;
                int acum = 0;
                for (int j = 1; j < arregloMatriz.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(arregloMatriz[i, j]);
                    acum += suma;
                }
                acumColumnas[c] = acum;
                c++;
            }
        }
        /*Este método sirve para poder sumar los datos acumulados acomodados en forma diagonal
         *de la matriz*/
        public void SumarDiagonal()
        {
            int d = 0;
            for (int i = 0; i < arregloMatriz.GetLength(0); i++)
            {
                int suma = 0;
                int acum = 0;
                for (int j = 1; j < arregloMatriz.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(arregloMatriz[i, j]);
                    acum += suma;
                }
                acumDiagonal[d] = acum;
                d++;
            }
        }
    }
}
