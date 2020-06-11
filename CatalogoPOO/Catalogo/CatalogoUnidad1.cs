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
    public partial class CatalogoUnidad1 : Form
    {
        public CatalogoUnidad1()
        {
            InitializeComponent();
        }

        private void btnRegresarUnidad1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMiPrimerProyectoConsola_Click(object sender, EventArgs e)
        {
            String Nombreprograma;
            String ruta;

            Nombreprograma = "MiPrimerProyectoConsola.exe";
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

        private void btnMiProyectoWindowsForms_Click(object sender, EventArgs e)
        {
            Miproyectowindowsforms.Form1 Miproyectowindowsforms = new Miproyectowindowsforms.Form1();
            Miproyectowindowsforms.Show();
        }
    }
}
