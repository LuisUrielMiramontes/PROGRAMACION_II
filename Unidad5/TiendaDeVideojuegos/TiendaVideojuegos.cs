using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeVideojuegos
{
    class TiendaVideojuegos
    {
        /*Aquí se crean las propiedades con el fin de heredarlas y asignarles un valor*/
        public string NombreTienda { get; set; }
        public int NumProductos { get; set; }
        public double Precios { get; set; }
        public string Productos { get; set; }
        public string[,] ProductosPrecios { get; set; }
        /*Este método sirve para poder registrar el número de productos*/
        public void ProductosRegistrados()
        {
            Productos = "Productos disponibles: " + NumProductos + " ";
        }
    }
}