using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recibo
{
    class ClassRecibo
    {
        //Atributos
        public double kw = 0, pago = 0;
        public string contrato, tipo;
        //Métodos
        public void cobro()
        {
            if (tipo == "Hogar")
            {
                if (kw > 0 & kw < 250)
                {
                    pago = kw * 0.65;
                }
                else if (kw >= 251 & kw < 1200)
                {
                    pago = kw * 0.85;
                }
                else if (kw >= 1201 & kw < 2100)
                {
                    pago = kw * 1.5;
                }
                else if (kw >= 2101)
                {
                    pago = kw * 3.5;
                }
        }
        else if (tipo == "Negocio")
            {
                pago = kw * 5;
            }
        }
    }
}