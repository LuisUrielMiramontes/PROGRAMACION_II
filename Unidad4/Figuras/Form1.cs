using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        //Objetos
        Cuadrado objCuadrado = new Cuadrado();
        Triangulo objTriangulo = new Triangulo();
        Circulo objCirculo = new Circulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultadosCuadrado_Click(object sender, EventArgs e)
        {
            objCuadrado.Lado = Convert.ToDouble(txtLadoCuadrado.Text);
            objCuadrado.Figuras();
            lblAreaCuadrado.Text = "Área del cuadrado: " + objCuadrado.Area.ToString();
            lblPerimetroCuadrado.Text = "Perímetro del cuadrado: " + objCuadrado.Perimetro.ToString();
        }

        private void btnResultadosTriangulo_Click(object sender, EventArgs e)
        {
            objTriangulo.BaseTriangulo = Convert.ToDouble(txtBaseTriangulo.Text);
            objTriangulo.Altura = Convert.ToDouble(txtAlturaTriangulo.Text);
            objTriangulo.Figuras();
            lblAreaTriangulo.Text = "Área del triangulo: " + objTriangulo.Area.ToString();
            lblPerimetroTriangulo.Text = "Perímetro del triangulo: " + objTriangulo.Perimetro.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnResultadosCirculo_Click(object sender, EventArgs e)
        {
            objCirculo.Radio = Convert.ToDouble(txtRadioCirculo.Text);
            objCirculo.Circunferencia = Convert.ToDouble(txtCircunferenciaCirculo.Text);
            objCirculo.Figuras();
            lblAreaCirculo.Text = "Área del círculo: " + objCirculo.Area.ToString();
            lblPerimetroCirculo.Text = "Perímetro del círculo: " + objCirculo.Perimetro.ToString();
        }
    }
}
