using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDeEdad
{
    class ClassPersona
    {
        //Atributos
        public int diaNac = 0, mesNac = 0, anioNac = 0;
        public int diaAct = 0, mesAct = 0, anioAct = 0;
        public string mayorEdad;
        
        //Métodos
        public void MayoresDeEdad()
        {
            if (anioAct - anioNac > 10)
            {
                mayorEdad = "Es mayor de edad";
            }
        else if (anioAct - anioNac == 10)
            {
                if (mesAct > mesNac)
                {
                    mayorEdad = "Es mayor de edad";
                }
            else if (mesAct == mesNac)
                {
                    if (diaAct > diaNac)
                    {
                        mayorEdad = "Es mayor de edad";
                    }
                    else if (diaAct == diaNac)
                    {
                        mayorEdad = "Mayor de edad";
                    }
                }
            }
        }
    }
}
