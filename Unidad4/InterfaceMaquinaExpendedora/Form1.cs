using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceMaquinaExpendedora
{
    public partial class Form1 : Form
    {
        //Objetos: Para poder programar los botones, primero se necesita crear los objetos...
        //...donde se guardan los datos para así, poder mandar llamar las propiedades de las...
        //...clases e interfaces creadas.
        Bebidas objCocaCola = new Bebidas();
        Bebidas objDrPepper = new Bebidas();
        Producto objTipoProducto = new Producto();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCocaCola_Click(object sender, EventArgs e)
        {
            //Aquí se tienen que mandar a llamar los objetos creados juntos con algunas...
            //... propiedades, para así guardarlos y despues poder mandar un mensaje con...
            //...los datos guardados.
            objTipoProducto.Refresco = Convert.ToString(cmbCocaCola.Text);
            objCocaCola.CocaCola = Convert.ToString(cmbCocaCola.Text);
            objCocaCola.tipoDeProducto();
            MessageBox.Show("Su producto seleccionado Coca-Cola " + objTipoProducto.Refresco + " cuesta " + objCocaCola.CocaCola);
        }

        private void btnDrPepper_Click(object sender, EventArgs e)
        {
            //Como ya mencionado anteriormente, aquí se tienen que mandar a llamar los objetos...
            //...creados juntos con algunas propiedades, para así guardarlos y despues poder...
            //...mandar un mensaje con los datos guardados.
            objTipoProducto.Refresco = Convert.ToString(cmbDrPepper.Text);
            objDrPepper.DrPepper = Convert.ToString(cmbDrPepper.Text);
            objDrPepper.tipoDeProducto();
            MessageBox.Show("Su producto seleccionado DrPepper " + objTipoProducto.Refresco + " cuesta " + objDrPepper.DrPepper);
        }
    }
}
