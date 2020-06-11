using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeVideojuegos
{
    public partial class Form1 : Form
    {
        /*Maestra, disculpe por entregar el programa tarde, mi laptop duró actualizandose ayer todo el día
         y apenas acabó de terminar de actualizarse, espero y me pueda calificar el programa :c*/

        /*Aquí se crea un objeto que manda a llamar las propiedades de la clase y se crea un contador
         que se usará mas adelante*/
        TiendaVideojuegos objTienda = new TiendaVideojuegos();
        StreamWriter objDatos;
        string almacenar = "";
        int p = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            /*Por medio de un "NumericUpDown" indica la cantidad de productos a registrar
             incluyendo datos de la tienda, el número, nombre y precio del producto*/
            objTienda.NombreTienda = txtNombreTienda.Text;
            objTienda.NumProductos = (int)nudNumProductos.Value;
            objTienda.ProductosPrecios = new string[objTienda.NumProductos, 3];
            for (int f = 0; f < objTienda.ProductosPrecios.GetLength(0); f++)
            {
                objTienda.ProductosPrecios[f, 0] = Microsoft.VisualBasic.Interaction.InputBox("Introduce el nombre del producto #" + (f + 1));
                objTienda.ProductosPrecios[f, 1] = Microsoft.VisualBasic.Interaction.InputBox("Introduce el precio del producto #" + (f + 1));
                objTienda.ProductosPrecios[f, 2] = p++.ToString();                                                                  
            }
            MessageBox.Show("Los productos han sido registrados correctamente.");
        }
        private void btnImprimirProductos_Click(object sender, EventArgs e)
        {
            /*Aquí es donde se imprimen los productos registrados dentro de un "RichTextBox"
             por medio de un arreglo bidimensional llamado "ProductosPrecios[,]"*/
            objTienda.ProductosRegistrados();
            for (int f = 0; f < objTienda.ProductosPrecios.GetLength(0); f++)
            {
                rtbProductosRegistrados.Text += "Tienda: " + objTienda.NombreTienda + "\n";
                rtbProductosRegistrados.Text += "Producto #" + objTienda.ProductosPrecios[f,2] + "\n" + "Nombre del producto: " + objTienda.ProductosPrecios[f,0];              
                rtbProductosRegistrados.Text += "\n"+ "Precio: " + objTienda.ProductosPrecios[f,1] + " \r\r";
                objDatos = new StreamWriter("TiendaDeVideojuegos.txt");
                objDatos.Write(rtbProductosRegistrados.Text);
                objDatos.Close();
                Console.ReadLine();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            /*Simplemente cierra el programa*/
            Close();
        }

        private void rtbProductosRegistrados_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
