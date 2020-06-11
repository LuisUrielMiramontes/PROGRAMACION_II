using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesProg101
{
    class CrearArchivo
    {
        /*Se crea un archivo de texto...*/
        public void CrearArchivoDeTexto()
        {
            using (Stream fsl = new FileStream("./escribirarchivo.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fsl))
                {
                    Console.WriteLine("Esto es un archivo de texto hecho en C#");
                }
            }
        }
    }
}
