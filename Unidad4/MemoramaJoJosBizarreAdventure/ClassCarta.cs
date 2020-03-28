using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoramaJoJosBizarreAdventure
{
    abstract class ClassCarta
    {
        //Atributos: Estos atributos son la herencia de la interface, pero...
        //...como estan privadados, se tiene que crear varias propiedades para así...
        //...poder utilizarlas.
        private int tamanioColumnasFilas = 0, movimientos = 0, cantidadDeCartasVolteadas = 0, cartaActual = 0;
        private int contadorFichas = 0, tiempoVirarCarta = 1;

        //Propiedades: Estas propiedades hacen el trabajo de los atributos privados.
        public int TamanioColumnasFilas
        {
            set { tamanioColumnasFilas = value; }
            get { return tamanioColumnasFilas; }
        }
        public int Movimientos
        {
            set { movimientos = value; }
            get { return movimientos; }
        }
        public int CantidadDeCarasVolteadas
        {
            set { cantidadDeCartasVolteadas = value; }
            get { return cantidadDeCartasVolteadas; }
        }
        public int CartaActual
        {
            set { cartaActual = value; }
            get { return cartaActual; }
        }
        public int ContadorFichas
        {
            set { contadorFichas = value; }
            get { return contadorFichas; }
        }
        public int TiempoVirarCarta
        {
            set { tiempoVirarCarta = value; }
            get { return tiempoVirarCarta; }
        }

        //Contructor: Lo que hace el constructor es darle algun valor prederterminado...
        //...a los atributos privados.
        public ClassCarta()
        {
            tamanioColumnasFilas = 0;
            movimientos = 0;
            cantidadDeCartasVolteadas = 0;
            cartaActual = 0;
            contadorFichas = 0;
            tiempoVirarCarta = 1;
        }

        //Método: Este método lo que hace es, como dice su propio nombre, iniciar todo el juego del...
        //...memorama de JoJo's Bizarre Adventure.
        public abstract void iniciarJuego();
    }
}
