using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bidimensional2
{
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        int[,] arrayA = new int[100, 100];
        int[,] arrayB = new int[100, 100];
        int[,] arrayC = new int[100, 100];
        int fil;
        int col;
        int i, j;
        string acumA;
        string acumB;
        string acumC;

        private void btnIngresarDatosA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz A", "Ingresar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            for (i = 0; i < fil; i++)
            {
                acumA += "\r\n";
                for (j = 0; j < col; j++)
                {
                    arrayA[i, j] = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox(" Matriz A " + i + ", " + j));
                    acumA += arrayA[i, j] + " \n";
                    txtA.Text = acumA;
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            for (i = 0; i < col; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
                    acumC = arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            acumA = "";
            acumB = "";
            acumC = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            for (i = 0; i < col; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] - arrayB[i, j];
                    acumC = arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }
            }
        }
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            for (i = 0; i < col; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] * arrayB[i, j];
                    acumC = arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            for (i = 0; i < fil; i++)
            {
                acumC += "\r\n\n";
                for (j = 0; j < col; j++)
                {
                    arrayC[i, j] = arrayA[i, j] / arrayB[i, j];
                    acumC = arrayC[i, j] + " \n";
                    txtC.Text = acumC;
                }
            }
        }
        private void btnIngresarDatosB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matriz B", "Ingresar Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            for (i = 0; i < fil; i++)
            {
                acumB += "\r\n";
                for (j = 0; j < col; j++)
                {
                    arrayB[i, j] = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox(" Matriz B " + i + ", " + j));
                    acumB += arrayB[i, j] + " \n";
                    txtB.Text = acumB;
                }
            }
        }
        private void btnTamañoMatriz_Click(object sender, EventArgs e)
        {
            fil = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantas filas tiene la matriz?"));
            col = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("¿Cuantas columnas tiene la matriz?"));
        }
    }
}
