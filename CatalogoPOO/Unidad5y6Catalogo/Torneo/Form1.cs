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

namespace Torneo
{
    public partial class Form1 : Form
    {
        /*Aquí se crea el objeto para mandar a llamar las propiedades y métodos creadas en la clase
         "Torneo"*/
        Torneo objTorneo = new Torneo();
        StreamWriter objDatos;
        string almacenar = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void lblEmpate_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /*Esto solamente cierra el programa*/
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*Esto guarda los datos ingresados del programa que despues de ingresarlos, manda un
             mensaje indicando que ya los guardó*/
            objTorneo.NombreTorneo = Convert.ToString(txtNombreTorneo.Text);
            objTorneo.NumEquipos = (int)nudNumEquipos.Value;
            objTorneo.FechaInicio = dtpFechaInicio.Value;
            objTorneo.FechaFin = dtpFechaFin.Value;
            MessageBox.Show("Los datos se han guardado correctamente.");
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            /*Aquí se usa el objeto para poder mandar a llamar las propiedades y métodos para
             darles un valor y así poder usarlos por medio de los arreglos con el fin de sacar
             el resultado del partido*/
            objTorneo.PuntajeXPartidos = new string[objTorneo.NumEquipos,objTorneo.NumEquipos];
            for (int f = 0; f < objTorneo.PuntajeXPartidos.GetLength(0); f++)
            {
                objTorneo.PuntajeXPartidos[f, 0] = Interaction.InputBox("Introduce el nombre del equipo #" + (f + 1));
                for (int c = 1; c < objTorneo.PuntajeXPartidos.GetLength(1); c++)
                {
                    objTorneo.PuntajeXPartidos[f, c] = Interaction.InputBox("Introduce el puntaje obtenido en el partido #" + c );                    
                }
                MessageBox.Show("Los resultados han sido ingresados correctamente.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            /*Esto solamente limpia los datos ingresados para poder ingresar datos nuevos*/
            txtNombreTorneo.Text = "";
            nudNumEquipos.ResetText();
            dtpFechaInicio.ResetText();
            dtpFechaFin.ResetText();
        }

        private void btnGanador_Click(object sender, EventArgs e)
        {
            /*Aquí se imprime los datos finales del ganador del torneo*/
            objTorneo.PuntosFinal = new int[objTorneo.NumEquipos];
            objTorneo.CalcularPuntosObtenidos();
            MessageBox.Show(objTorneo.CalcularGanador());
            objDatos = new StreamWriter("Torneo.txt");
            objDatos.Write(objTorneo.CalcularGanador());
            objDatos.Close();
            Console.ReadLine();
        }
    }
}