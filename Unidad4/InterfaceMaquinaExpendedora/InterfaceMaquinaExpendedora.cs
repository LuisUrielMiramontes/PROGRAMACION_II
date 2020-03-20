using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMaquinaExpendedora
{
    interface InterfaceMaquinaExpendedora
    {
        //Propiedad: Esta propiedad tiene la función de realizar todo lo que este relacionado...
        //...al prodcto, ya sea el tipo y el costo en este caso, ademas esta dentro de la...
        //...interface y solamente lo hereda a las otras clases.
        string tipoDeProducto { set; get; }
    }
}
