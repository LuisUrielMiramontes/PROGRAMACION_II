using System;
using System.Collections.Generic;
using System.IO;
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
            StreamWriter objDatos;
            string almacenar = "";

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
            almacenar += objPaises.NombrePais + " ";
            almacenar += objPaises.PoblacionPais + " ";
            almacenar += objPaises.IdiomaPais + " ";
            almacenar += objPaises.ColoresPais[0] + " ";
            almacenar += objPaises.ColoresPais[1] + " ";
            almacenar += objPaises.ColoresPais[2];
            //Luego se imprimen.
            Console.WriteLine("Los datos ingresados del país son: ");
            Console.WriteLine("Nombre del País: " + objPaises.NombrePais);
            Console.WriteLine("Total de Población: " + objPaises.PoblacionPais);
            Console.WriteLine("Idioma: " + objPaises.IdiomaPais);
            Console.WriteLine("Color #1: " + objPaises.ColoresPais[0]);
            Console.WriteLine("Color #2: " + objPaises.ColoresPais[1]);
            Console.WriteLine("Color #3: " + objPaises.ColoresPais[2]);
            objDatos = new StreamWriter("Ejercicio1Paises.txt");
            objDatos.Write(almacenar);
            objDatos.Close();
            Console.ReadLine();
        }
    }
}
