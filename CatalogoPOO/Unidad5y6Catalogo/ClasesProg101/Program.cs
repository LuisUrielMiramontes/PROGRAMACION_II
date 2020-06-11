using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesProg101
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se crea un objeto donde manda a llamar los métodos creados en las clases...*/
            LeerArchivo objLeerArchivo = new LeerArchivo();
            CrearArchivo objCrearArchivo = new CrearArchivo();
            objLeerArchivo.LeerArchivoDeTexto1();
            objLeerArchivo.LeerArchivoDeTexto2();
            objCrearArchivo.CrearArchivoDeTexto();
            Console.ReadKey();
        }
    }
}
