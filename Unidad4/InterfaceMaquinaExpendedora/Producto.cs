using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMaquinaExpendedora
{
    class Producto
    {
        //Atributo: Este atributo representa el tipo de refresco que se va a seleccionar, pero...
        //...como esta privada, se tiene que crear una propiedad.
        private string refresco;

        //Propiedad: Esta propiedad hace el trabajo de el atributo "refresco".
        public string Refresco
        {
            set { refresco = value; }
            get { return refresco; }
        }

        //Método: Este método es tecnicamente la propiedad del interface (heredada), lo que hace...
        //...este método es mediante un combobox, lo que ocurre si se escoje alguna opcion.
        public virtual void tipoDeProducto()
        {
            if (Refresco == "Lata 350ml")
            {
                Refresco = "Lata 350ml";
            }
            else if (Refresco == "Botella 600ml")
            {
                Refresco = "Botella 600ml";
            }
        }
    }
}
