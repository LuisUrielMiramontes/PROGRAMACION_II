using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoramaJoJosBizarreAdventure
{
    interface InterfaceMemoramaJoJo
    {
        //Propiedades: Estas propiedades tienen la función de realizar todo lo que este...
        //...relacionado al memorama en sí como por ejemplo, el número de cartas, los movimientos...
        //...etc. Ademas esta dentro de la interface y solamente lo hereda a las otras clases.
        int TamanioColumnasFilas { set; get; }
        int Movimientos { set; get; }
        int CantidadDeCartasVolteadas { set; get; }
        int CartaActual { set; get; }
        int contadorFichas { set; get; }
        int TiempoVirarCarta { set; get; }

        void iniciarJuego();
    }
}
