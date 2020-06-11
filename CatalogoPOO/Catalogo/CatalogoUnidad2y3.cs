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
    public partial class btnCatalogoUnidad2y3 : Form
    {
        public btnCatalogoUnidad2y3()
        {
            InitializeComponent();
        }

        private void btnEmbotelladora_Click(object sender, EventArgs e)
        {
            Embotelladora.frm Embotelladora = new Embotelladora.frm();
            Embotelladora.Show();
        }

        private void btnEntradasDeUnConcierto_Click(object sender, EventArgs e)
        {
            EntradasDeUnConcierto.Form1 EntradasDeUnConcierto = new EntradasDeUnConcierto.Form1();
            EntradasDeUnConcierto.Show();
        }

        private void btn1Cuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado.Form1 Cuadrado = new Cuadrado.Form1();
            Cuadrado.Show();
        }

        private void btn2Temperatura_Click(object sender, EventArgs e)
        {
            Temperatura.Form1 Temperatura = new Temperatura.Form1();
            Temperatura.Show();
        }

        private void btn3DiasDeVacaciones_Click(object sender, EventArgs e)
        {
            DiasDeVacaciones.Form1 DiasDeVacaciones = new DiasDeVacaciones.Form1();
            DiasDeVacaciones.Show();
        }

        private void btn4MayorDeEdad_Click(object sender, EventArgs e)
        {
            MayorDeEdad.Form1 MayorDeEdad = new MayorDeEdad.Form1();
            MayorDeEdad.Show();
        }

        private void btn5Recibo_Click(object sender, EventArgs e)
        {
            Recibo.Form1 Recibo = new Recibo.Form1();
            Recibo.Show();
        }

        private void btn6CasetaDeAutopista_Click(object sender, EventArgs e)
        {
            CasetaDeAutopista.Form1 CasetaDeAutopista = new CasetaDeAutopista.Form1();
            CasetaDeAutopista.Show();
        }

        private void btnExamen2y3_Click(object sender, EventArgs e)
        {
            Examen2y3.Form1 Examen2y3 = new Examen2y3.Form1();
            Examen2y3.Show();
        }

        private void btnRegresarUnidad2y3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
