<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaDeCalificaciones
{
    class ClassCalificaciones
    {
        public decimal calLeida = 0, promedio = 0, suma = 0;
        public int aprobados = 0, reprobados = 0, contador =0;

        public void CapturarCalificación()
        {
            if (calLeida >= 70)
            {
                aprobados++;
                suma += calLeida;
            }
            else
            {
                reprobados++;
                suma += calLeida;
            }
            contador++;
            promedio = suma / contador;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapturaDeCalificaciones
{
    class ClassCalificaciones
    {
        public decimal calLeida = 0, promedio = 0, suma = 0;
        public int aprobados = 0, reprobados = 0, contador =0;

        public void CapturarCalificación()
        {
            if (calLeida >= 70)
            {
                aprobados++;
                suma = suma + calLeida;
            }
            else
            {
                reprobados++;
                suma = suma + calLeida;
            }
            contador++;
            promedio = suma / contador;
        }
    }
}
>>>>>>> 34577a1e150897941f94a7b626ac070dfc977259
