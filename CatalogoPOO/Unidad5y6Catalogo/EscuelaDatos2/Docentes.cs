using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaDatos2
{
    class Docentes : Personas
    {
        //Propiedades de la clase "Docente" donde por medio de un objeto, se mandan a llamar.
        public int[] NumeroMaes;
        public decimal[] Sueldo;
        public string[] MateriasImparte;
    }
}
