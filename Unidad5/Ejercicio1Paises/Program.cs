using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Paises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto
            DatosPaises objPaises = new DatosPaises();

            //Solamente guarda los datos.
            Console.WriteLine("Introduce el nombre del país: ");
            objPaises.NombrePais = Console.ReadLine();
            Console.WriteLine("Introduce la población del país: ");
            objPaises.PoblacionPais = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el idioma predominante del país: ");
            objPaises.IdiomaPais = Console.ReadLine();
            Console.WriteLine("Introduce los colores principales de la bandera del país: ");
            objPaises.ColoresPais = new string[3];
            Console.WriteLine("Color #1: ");
            objPaises.ColoresPais[0] = Console.ReadLine();
            Console.WriteLine("Color #2: ");
            objPaises.ColoresPais[1] = Console.ReadLine();
            Console.WriteLine("Color #3: ");
            objPaises.ColoresPais[2] = Console.ReadLine();

            //Luego se imprimen.
            Console.WriteLine("Los datos ingresados del país son: ");
            Console.WriteLine("Nombre del País: " + objPaises.NombrePais);
            Console.WriteLine("Total de Población: " + objPaises.PoblacionPais);
            Console.WriteLine("Idioma: " + objPaises.IdiomaPais);
            Console.WriteLine("Color #1: " + objPaises.ColoresPais[0]);
            Console.WriteLine("Color #2: " + objPaises.ColoresPais[1]);
            Console.WriteLine("Color #3: " + objPaises.ColoresPais[2]);
            Console.ReadLine();
        }
    }
}
