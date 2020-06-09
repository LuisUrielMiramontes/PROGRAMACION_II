using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1PropuestoArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aquí se declaran las variables y se agrega un arreglo "i" donde a esta se le da un valor,...
            //...se limita que sea menor a 3 y un contador.
            Double[] Sueldos;
            Sueldos = new Double[3];
            StreamWriter objDatos;
            string almacenar = "";
            for (int i = 0; i < 3; i++)
            {
                //Esto se añade para poder mandar un mensaje que diga "Ingrese el sueldo del Empleado #"...
                //...y poder ingresar los sueldos de 3 empleados por medio de la "i".
                Console.WriteLine("Ingrese el sueldo del Empleado #" + (i + 1) + ":");
                Sueldos[i] = Double.Parse(Console.ReadLine());
                almacenar += Sueldos[i] + " ";
            }
            //Esto hace que muestre los sueldos en pantalla.
            Mostrar(Sueldos);
            objDatos = new StreamWriter("Ejemplo1PropuestoArreglos.txt");
            objDatos.Write(almacenar);
            objDatos.Close();
            Console.ReadLine();
        }
         static void Mostrar(Double[] Sueldos)
         {
            //Aquí se añade el texto "Los sueldos ingresados son:" y otro arreglo "i" que como antes...
            //...mencionado, donde a esta se le da un valor, se limita que sea menor a 3 y un contador...
            //...para así mostrar los sueldos ingresados en pantalla de tal manera que esten ordenados.
            Console.WriteLine("Los sueldos ingresados son:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t" + Sueldos[i]);
            }
        }
    }
}
