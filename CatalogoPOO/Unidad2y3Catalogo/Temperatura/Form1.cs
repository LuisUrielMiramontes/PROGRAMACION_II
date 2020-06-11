using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        ClassTemperatura objTemperatura = new ClassTemperatura();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtGrados_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objTemperatura.grado = Convert.ToDouble(txtGrados.Text);
            objTemperatura.tipo = (cboxTipo.Text.ToString());
            objTemperatura.ConvertirCelsius();
            objTemperatura.ConvertirFahrenheit();
            lblGrados.Text = "Grados: " + objTemperatura.grado.ToString() + objTemperatura.resultado.ToString();
            txtGrados.Text = "";
            cboxTipo.Text = "";
        }
    }
}
