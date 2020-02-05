using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Introduce un numero: ");
            a = Convert.ToInt32 (Console.ReadLine());

            Console.Write("Introduce un numero: ");
            b = Convert.ToInt32 (Console.ReadLine());

            c = a + b;

            Console.WriteLine("La suma de los nummeros introducidos es: " + c);
            Console.ReadKey();
        }
    }
}
