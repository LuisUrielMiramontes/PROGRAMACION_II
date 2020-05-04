using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torneo
{
    class Torneo
    {
        //Estas propiedes se crean aquí para despues heredarlas al "Forms1.cs"
        public string NombreTorneo { get; set; }
        public int NumEquipos { get; set; }
        public int NumPartidos { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int PuntosGanador { get; set; }
        public int PuntosEmpate { get; set; }
        public int PuntosPerdedor { get; set; }
        public int[] PuntosFinal { get; set; }
        public string[,] PuntajeXPartidos { get; set; }
        /*Como su mismo nombre lo dice, este método sirve para calcular los puntos obtenidos
         de un partido*/
        public void CalcularPuntosObtenidos()
        {
            int p = 0;
            for (int i = 0; i < PuntajeXPartidos.GetLength(0); i++)
            {
                int suma=0;
                int acum = 0;
                for (int j = 1; j < PuntajeXPartidos.GetLength(1); j++)
                {
                    suma = Convert.ToInt32(PuntajeXPartidos[i, j]);
                    acum += suma;
                }
                PuntosFinal[p] = acum;
                p++;
            }
        }
        /*Mientras que este método, sirve para calcular el ganador por medio de un ciclo "for"*/
        public string CalcularGanador()
        {
            int NumGanador = 0;
            int f = 0;
            int NumMayor = 0;
            string Ganador = "";
            for (int i = 0; i < PuntosFinal.Length; i++)
            {
                if (PuntosFinal[i] > NumMayor)
                {
                    NumMayor = PuntosFinal[i];
                    NumGanador = f;
                }
                f++;
            }
            Ganador = "¡El equipo ganador del torneo " + NombreTorneo + " es: " + PuntajeXPartidos[NumGanador, 0] + " con " + NumMayor + " puntos! ¡Felicidades!";
            return Ganador;
        }
    }
}
