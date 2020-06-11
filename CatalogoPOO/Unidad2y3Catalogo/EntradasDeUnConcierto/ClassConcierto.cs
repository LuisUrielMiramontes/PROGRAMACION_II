using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradasDeUnConcierto
{
    class ClassConcierto
    {
        //Atributos
        public String categoria;
        public int personas;

        //Variables usadas en métodos
        public int bebe = 0, nino = 0, adulto = 0, tEdad = 0;

        //Métodos
        public void ContabilizarEntradas()
        {
            switch (categoria)
            {
                case "Bebé":
                 {
                        bebe = bebe + personas;
                        break;
                 }
                case "Niño":
                 {
                        nino = nino + personas;
                        break;
                 }
                case "Adulto":
                 {
                        adulto = adulto + personas;
                        break;
                 }
                case "Tercera edad":
                 {
                        tEdad = tEdad + personas;
                        break;
                 }
            }
        }

    }
}
