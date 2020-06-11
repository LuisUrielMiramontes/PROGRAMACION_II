using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class CatalogoUnidad6 : Form
    {
        public CatalogoUnidad6()
        {
            InitializeComponent();
        }
        private void btnBidimensional1_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "Bidimensional1.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void btnBidimensional2_Click(object sender, EventArgs e)
        {
            Bidimensional2.Form1 Bidimensional2 = new Bidimensional2.Form1();
            Bidimensional2.Show();
        }

        private void btnBidimensionalEjemplo1_Click(object sender, EventArgs e)
        {
            BidimensionalEjemplo1.Form1 BidimensionalEjemplo1 = new BidimensionalEjemplo1.Form1();
            BidimensionalEjemplo1.Show();
        }

        private void btnEjemplo1PropuestoArreglos_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "Ejemplo1PropuestoArreglos.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void btnEjercicio1Paises_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "Ejercicio1Paises.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void btnEjercicio2Paises_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "Ejercicio2Paises.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void btnEjercicioArrayListDeUnaClase_Click(object sender, EventArgs e)
        {
            EjercicioArrayListDeUnaClase.Form1 EjercicioArrayListDeUnaClase = new EjercicioArrayListDeUnaClase.Form1();
            EjercicioArrayListDeUnaClase.Show();
        }

        private void btnEscuelaDatos1_Click(object sender, EventArgs e)
        {
            EscuelaDatos1.Form1 EscuelaDatos1 = new EscuelaDatos1.Form1();
            EscuelaDatos1.Show();
        }

        private void btnEscuelaDatos2_Click(object sender, EventArgs e)
        {
            EscuelaDatos2.Form1 EscuelaDatos2 = new EscuelaDatos2.Form1();
            EscuelaDatos2.Show();
        }

        private void btnMatrizSumaFCD_Click(object sender, EventArgs e)
        {
            MatrizSumaFCD.Form1 MatrizSumaFCD = new MatrizSumaFCD.Form1();
            MatrizSumaFCD.Show();
        }

        private void btnNumerosMayorMenor_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "NumerosMayorMenor.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void btnTiendaDeVideojuegos_Click(object sender, EventArgs e)
        {
            TiendaDeVideojuegos.Form1 TiendaDeVideojuegos = new TiendaDeVideojuegos.Form1();
            TiendaDeVideojuegos.Show();
        }

        private void btnTorneo_Click(object sender, EventArgs e)
        {
            Torneo.Form1 Torneo = new Torneo.Form1();
            Torneo.Show();
        }

        private void btnClasesProg101_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "ClasesProg101.exe";
            ruta = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            ruta = ruta.Substring(6);
            ruta = String.Concat("\"", ruta, "\\", Nombreprograma, "\"");

            string cmdexeruta = @"C:\Windows\System32\cmd.exe";
            string cmdArguments2 = String.Format("/K {0}", ruta);
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(cmdexeruta, cmdArguments2);
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void btnRegresarUnidad6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
