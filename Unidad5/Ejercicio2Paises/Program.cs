using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Paises
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Objeto
            NDatosPaises objPaises = new NDatosPaises();

            //Contador del número de países ingresados.
            int numeroPais = 0;
            Console.WriteLine("¿Cuántos países deseas ingresar?");
            numeroPais = int.Parse(Console.ReadLine());

            //Estos arreglos tienen la función de mandar un mensaje con el fin de ingresar datos...
            //...según lo que requiera.
            String[] PaisesNombre;
            PaisesNombre = new String[numeroPais];
            for (int i = 0; i < numeroPais; i++)
            {
                Console.WriteLine("Ingrese el nombre del país #" + (i + 1) + ":");
                PaisesNombre[i] = Convert.ToString(Console.ReadLine());
            }

            int[] PaisesPoblacion;
            PaisesPoblacion = new int[numeroPais];
            for (int i = 0; i < numeroPais; i++)
            {
                Console.WriteLine("Ingrese el total de población del país #" + (i + 1) + ":");
                PaisesPoblacion[i] = int.Parse(Console.ReadLine());
            }

            String[] PaisesIdioma;
            PaisesIdioma = new String[numeroPais];
            for (int i = 0; i < numeroPais; i++)
            {
                Console.WriteLine("Ingrese el idioma predominante del país #" + (i + 1) + ":");
                PaisesIdioma[i] = Convert.ToString(Console.ReadLine());
            }

            String[] PaisesBandera1;
            PaisesBandera1 = new String[numeroPais];
            for (int i = 0; i < numeroPais; i++)
            {
                Console.WriteLine("Color #1 de la bandera del país #" + (i + 1) + ":");
                PaisesBandera1[i] = Convert.ToString(Console.ReadLine());
            }

            String[] PaisesBandera2;
            PaisesBandera2 = new String[numeroPais];
            for (int i = 0; i < numeroPais; i++)
            {
                Console.WriteLine("Color #2 de la bandera del país #" + (i + 1) + ":");
                PaisesBandera2[i] = Convert.ToString(Console.ReadLine());
            }

            String[] PaisesBandera3;
            PaisesBandera3 = new String[numeroPais];
            for (int i = 0; i < numeroPais; i++)
            {
                Console.WriteLine("Color #3 de la bandera del país #" + (i + 1) + ":");
                PaisesBandera3[i] = Convert.ToString(Console.ReadLine());
            }

            Mostrar(numeroPais, PaisesNombre, PaisesPoblacion, PaisesIdioma, PaisesBandera1, PaisesBandera2, PaisesBandera3);
            Console.ReadKey();
        }
        //Esto hace que imprima los datos ingresados.
        private static void Mostrar(int numeroPais, string[] paisesNombre, int[] paisesPoblacion, string[] paisesIdioma, string[] paisesBandera1, string[] paisesBandera2, string[] paisesBandera3)
        {
            Console.WriteLine("Los datos de los países ingesados son:");
            {
                for (int i = 0; i < numeroPais; i++)
                {
                    Console.WriteLine("\t - " + "Nombre del país #" + (i + 1 + ": ") + paisesNombre[i]);
                    Console.WriteLine("\t   " + "Población total del país #" + (i + 1 + ": ") + paisesPoblacion[i]);
                    Console.WriteLine("\t   " + "Idioma predominante del país #" + (i + 1 + ": ") + paisesIdioma[i]);
                    Console.WriteLine("\t   " + "Los 3 colores principales de la bandera del país #" + (i + 1 + ": "));
                    Console.WriteLine("\t   " + "Color #1: " + (paisesBandera1[i]));
                    Console.WriteLine("\t   " + "Color #2: " + (paisesBandera2[i]));
                    Console.WriteLine("\t   " + "Color #3: " + (paisesBandera3[i]));
                }
            }
        }
    }
}
