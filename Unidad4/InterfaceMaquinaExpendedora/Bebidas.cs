using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMaquinaExpendedora
{
    class Bebidas : Producto
    {
        //Atributos: Estos atributos representan el tipo de refresco que se va a seleccionar, pero...
        //...como estan privadas, se tiene que crear una propiedad.
        private string cocacola, drPepper;

        //Propiedades: Estas propiedades hacen el trabajo de los atributos "cocacola y drPepper".
        public string CocaCola
        {
            set { cocacola = value; }
            get { return cocacola; }
        }
        public string DrPepper
        {
            set { drPepper = value; }
            get { return drPepper; }
        }

        //Método: Ya mencionado anteriormente, este método es tecnicamente la propiedad del...
        //interface (heredada), lo que hace este método es, mediante un combobox en este caso...
        //...lo que ocurre si se escoje alguna opcion.
        public override void tipoDeProducto()
        {
            if (CocaCola == "Lata 350ml")
            {
                CocaCola = "$8 pesos";
            }
            else if (CocaCola == "Botella 600ml")
            {
                CocaCola = "$14 pesos";
            }

            if (DrPepper == "Lata 350ml")
            {
                DrPepper = "$10 pesos";
            }
            else if (DrPepper == "Botella 600ml")
            {
                DrPepper = "$16 pesos";
            }
        }
    }
}
