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
using Microsoft.VisualBasic;

namespace Bidimensional2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i, j;
        String acumArray;
        int[,] arrayBidi = new int[100, 100];
        String AcumPar;
        int Buscar;
        int Filas, Columnas;
        StreamWriter objDatos;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(acumArray, "Elementos del Arreglo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            objDatos = new StreamWriter("Bidimensional2.txt");
            objDatos.Write(acumArray);
            objDatos.Close();
            Console.ReadLine();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarNum.Text = "";
            txtColumnas.Text = "";
            txtFilas.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Filas = Convert.ToInt16(txtFilas.Text);
            Columnas = Convert.ToInt16(txtColumnas.Text);

            for (i = 0; i < Filas; i++)
            {
                acumArray += "\n";

                for (j = 0; j < Columnas; j++)
                {
                    arrayBidi[i, j] = Convert.ToInt16(Interaction.InputBox("Ingresa el valor " + i + "," + j));
                    acumArray += arrayBidi[i, j] + ",";
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar = Convert.ToInt16(txtBuscarNum.Text);
            for (i = 0; i < Filas; i++)
            {
                acumArray += "\n";
                for (j = 0; j < Columnas; j++)
                {
                    if (arrayBidi[i, j] == Buscar)
                    {
                        MessageBox.Show(Convert.ToString(Buscar), "El numero si existe", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    }
                    objDatos = new StreamWriter("BidimensionalBuscar2.txt");
                    objDatos.Write(Buscar);
                    objDatos.Close();
                    Console.ReadLine();
                }
            }
        }
        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            Operaciones objOper = new Operaciones();
            objOper.Show();
            this.Hide();
        }

        private void btnPar_Click(object sender, EventArgs e)
        {
            for (i = 0; i < Filas; i++)
            {
                AcumPar += "\n";
                for (j = 0; j < Columnas; j++)
                {
                    if (arrayBidi[i, j] % 2 == 0)
                    {
                        AcumPar += arrayBidi[i, j];
                    }
                    objDatos = new StreamWriter("BidimensionalPar2.txt");
                    objDatos.Write(AcumPar);
                    objDatos.Close();
                    Console.ReadLine();
                }
            }
            MessageBox.Show(AcumPar, "Números pares", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void txtBuscarNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
