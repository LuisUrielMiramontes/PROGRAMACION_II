using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiasDeVacaciones
{
    class ClassEmpleados
    {
        //Atributos
        public int diasVacaciones = 0, aniosTrabajados = 0;

        //Métodos
        public void DiasDeVacaciones()
        {
            if (aniosTrabajados>0 & aniosTrabajados<=5)
            {
                diasVacaciones = diasVacaciones + 5;
            }
            if (aniosTrabajados>=6 & aniosTrabajados<=10)
            {
                diasVacaciones = diasVacaciones + 10;
            }
            if (aniosTrabajados>=11 & aniosTrabajados<20)
            {
                diasVacaciones = aniosTrabajados*2;
            }
            if (aniosTrabajados>=20 & aniosTrabajados<=45)
            {
                diasVacaciones = aniosTrabajados * 4;
            }
            if (diasVacaciones>45)
            {
                diasVacaciones = 45;
            }
        }
    }
}
