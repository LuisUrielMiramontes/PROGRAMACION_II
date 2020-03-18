using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    class ClassAereo:ClassVehiculo
    {
        public int numeroTurbinas = 0, numeroAlas = 0, numeroHelices = 0;
        public string tipoAereo;

        //Método
        public ClassAereo()
        {
            numeroAlas = 0;
            numeroTurbinas = 0;
            numeroHelices = 0;
            tipoAereo = "";
        }
        public string EnVuelo (string estado)
        {
            return "El " + tipoAereo + "está volando" + estado;
        }
    }
}
