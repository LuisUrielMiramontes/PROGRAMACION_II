using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosMayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros objNumeros = new Numeros();
            Console.WriteLine("¿Cuántos números deseas ingresar?");
            objNumeros.ingresarNumeros = int.Parse(Console.ReadLine());
            for (int i = 0; i < objNumeros.ingresarNumeros; i++)
            {
                Console.WriteLine("Ingrese el número #" + (i + 1) + ":");
                objNumeros.ingresarNumeros = int.Parse(Console.ReadLine());
            }
            {
                if (objNumeros.menor < objNumeros.mayor)
                {
                    Console.WriteLine("El número mayor es: " + objNumeros.mayor);
                    Console.WriteLine("El número menor es: " + objNumeros.menor);
                }
                Console.WriteLine(objNumeros.SacarMayorMenor());
                Console.ReadLine();
            }
        }
    }
}
