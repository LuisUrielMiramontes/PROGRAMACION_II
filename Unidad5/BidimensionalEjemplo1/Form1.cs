using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BidimensionalEjemplo1
{
    public partial class Form1 : Form
    {
        int[,] arregloBidi;
        int[,] ab = new int[2, 3]; //(Número de filas predeterminada)
        int[,] ar = { { 2, 4, 5 }, { 4, 6, 7 } }; //(Números dentro de las columnas predeterminada)
        int filas;
        int columnas;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            filas = (int)nudFilas.Value;
            columnas = (int)nudColumnas.Value;

            arregloBidi = new int[filas, columnas];

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    arregloBidi[f, c] = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Introduce el elemento [" + f + "][ " + c + "]"));
                }
            }
            btnImprimir.Enabled = true;
            btnCapturar.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < arregloBidi.GetLength(1); c++)
                {
                    rtbArreglo.Text += arregloBidi[f, c] + " ";
                }
                rtbArreglo.Text += " \n";
            }
            btnCapturar.Enabled = true;
            btnImprimir.Enabled = false;
        }
    }
}
