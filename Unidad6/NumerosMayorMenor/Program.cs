using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosMayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter objDatos;
            string almacenar = "";
            Numeros objNumeros = new Numeros();

            Console.WriteLine("¿Cuántos números deseas ingresar?");
            objNumeros.ingresarNumeros = int.Parse(Console.ReadLine());
            objNumeros.arregloNumeros = new int[objNumeros.ingresarNumeros];
            for (int i = 0; i < objNumeros.ingresarNumeros; i++)
            {
                Console.WriteLine("Ingrese el número #" + (i + 1) + ":");
                objNumeros.arregloNumeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(objNumeros.SacarMayorMenor());
            almacenar += objNumeros.SacarMayorMenor();
            Console.ReadLine();        
            objDatos = new StreamWriter("NumerosMayorMenor.txt");
            objDatos.Write(almacenar);
            objDatos.Close();
            Console.ReadLine();
        }
    }
}
