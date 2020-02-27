using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuadrado
{
    public partial class Form1 : Form
    {
        ClassCuadrado objLado = new ClassCuadrado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            objLado.lado = int.Parse(txtLado.Text.ToString());
            objLado.SacarArea();
            lblArea.Text ="Área: " + objLado.area.ToString();
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            objLado.lado = int.Parse(txtLado.Text.ToString());
            objLado.SacarPerimetro();
            lblPerimetro.Text = "Perimetro: " + objLado.perimetro.ToString();
        }
    }
}
