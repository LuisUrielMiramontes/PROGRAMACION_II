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

namespace MatrizSumaFCD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Objeto que sirve para mandar a llamar las propiedades de la clase "MatrizFCD".*/
        MatrizFCD objMatriz = new MatrizFCD();
        StreamWriter objDatos;
        string almacenar = "";
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            /*Esto sirve para imprimir los datos ingresados en un "RichTextBox" de manera organizada 
             *como si fuera una matriz cuadrada.*/
            for (int f = 0; f < objMatriz.filas; f++)
            {
                for (int c = 0; c < objMatriz.arregloMatriz.GetLength(1); c++)
                {
                    rtbMatriz.Text += objMatriz.arregloMatriz[f, c] + " ";
                }
                rtbMatriz.Text += " \n";
            }
            btnCapturar.Enabled = true;
            btnImprimir.Enabled = false;
            objDatos = new StreamWriter("MatrizSumaFCD.txt");
            objDatos.Write(rtbMatriz.Text);
            objDatos.Close();
            Console.ReadLine();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            /*Esto sirve para poder capturar los datos ingresados y las organiza en forma de matriz*/
            objMatriz.filas = (int)nudFilasColumnas.Value;
            objMatriz.columnas = (int)nudFilasColumnas.Value;

            objMatriz.arregloMatriz = new int[objMatriz.filas, objMatriz.columnas];

            for (int f = 0; f < objMatriz.filas; f++)
            {
                for (int c = 0; c < objMatriz.columnas; c++)
                {
                    objMatriz.arregloMatriz[f, c] = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Ingresa el elemento [" + f + "][" + c + "]"));
                }
            }
            btnImprimir.Enabled = true;
            btnCapturar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /*Simplemente cierra el programa*/
            Close();
        }

        private void btnSumarFilas_Click(object sender, EventArgs e)
        {
            /*Esto sirve para poder sumar los datos acumulados de la fila de la matriz*/
            for (int f = 0; f < objMatriz.filas; f++)
            {
                rtbFilas.Text += objMatriz.arregloMatriz[f, 0] + " ";
            }
            rtbFilas.Text += " \n";
            objMatriz.acumFilas = new int[objMatriz.filas];
            objMatriz.SumarFilas();
            objDatos = new StreamWriter("MatrizSumaFCDFilas.txt");
            objDatos.Write(rtbFilas.Text);
            objDatos.Close();
            Console.ReadLine();
        }
        private void btnSumarColumnas_Click(object sender, EventArgs e)
        {
            /*Esto sirve para poder sumar los datos acumulados de la columna de la matriz*/
            for (int c = 0; c < objMatriz.columnas; c++)
            {
                rtbColumnas.Text += objMatriz.arregloMatriz[0, c] + " ";
            }
            rtbColumnas.Text += " \n";
            objMatriz.acumColumnas = new int[objMatriz.columnas];
            objMatriz.SumarColumnas();
            objDatos = new StreamWriter("MatrizSumaFCDColumnas.txt");
            objDatos.Write(rtbColumnas.Text);
            objDatos.Close();
            Console.ReadLine();
        }

        private void btnSumarDiagonal_Click(object sender, EventArgs e)
        {
            /*Esto sirve para poder sumar los datos acumulados acomodados en forma diagonal
             *de la matriz*/
            for (int f = 0; f < objMatriz.columnas; f++)
            {
                for (int c = 0; c < objMatriz.columnas; c++)
                {
                    rtbDiagonal.Text += objMatriz.arregloMatriz[1, 2] + " ";
                }
            }
            rtbColumnas.Text += " \n";
            objMatriz.acumDiagonal = new int[objMatriz.diagonal];
            objMatriz.SumarDiagonal();
            objDatos = new StreamWriter("MatrizSumaFCDDiagonal.txt");
            objDatos.Write(rtbDiagonal.Text);
            objDatos.Close();
            Console.ReadLine();
        }
    }
}
