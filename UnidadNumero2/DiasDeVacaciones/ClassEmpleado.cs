using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiasDeVacaciones
{
    class ClassEmpleado
    {
        //Atributos
        public int aniosTrabajados = 0, diasVacaciones = 0;

        //Métodos
        public void DiasDeVacaciones()
        {
            if (aniosTrabajados>0 & aniosTrabajados<=5)
            {
                diasVacaciones = diasVacaciones + 5;
            }
            else if (aniosTrabajados>=6 & aniosTrabajados<=10)
            {
                diasVacaciones = diasVacaciones + 10;
            }
            else if (aniosTrabajados>=11 & aniosTrabajados<20)
            {
                diasVacaciones = 10 + ((aniosTrabajados - 10) * 1);
            }
            else if (aniosTrabajados>=21)
            {
                diasVacaciones = 10 + ((aniosTrabajados - 10) * 1);
            }
            if (diasVacaciones>45)
            {
                diasVacaciones = 45;
            }
         }
     }
}
