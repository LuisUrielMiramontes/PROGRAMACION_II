using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesProg101
{
    class LeerArchivo
    {
        /*Obtienen el número de bytes y luego lee el archivo de texto seleccionado...*/
        public void LeerArchivoDeTexto1()
        {
            Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read);

            long Quality = fs.Length;
            Console.WriteLine($"El archivo tiene una longitud de {Quality} bytes");

            fs.Seek(0, SeekOrigin.Begin);
            StreamReader sr = new StreamReader(fs);

            string todo = sr.ReadToEnd();
            Console.WriteLine(todo);
        }
        public void LeerArchivoDeTexto2()
        {
            Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read);
            long Quality = fs.Length;
            Console.WriteLine($"El archivo tiene una longitud de {Quality} bytes");

            for (long count = 0; count < Quality; count++)
            {
                fs.Seek(count, SeekOrigin.Begin);
                int valor = fs.ReadByte();
                Console.WriteLine($"Posición {count}: {(char)valor}");
            }
            fs.Close();
        }
    }
}
