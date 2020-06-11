using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntradasDeUnConcierto
{
    public partial class Form1 : Form
    {
        ClassConcierto objConcierto = new ClassConcierto();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objConcierto.categoria = cboxCategoria.SelectedItem.ToString();
            objConcierto.personas = int.Parse(cboxNumero.Text);
            objConcierto.ContabilizarEntradas();
            MessageBox.Show("Se capturaron los datos de asistentes al concierto de Green Day");
            cboxCategoria.Text = "";
            cboxNumero.Text = "";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            objConcierto.categoria = cboxNumero.Text;
            lblBebe.Text = "Bebes: " + objConcierto.bebe.ToString();
            lblNiño.Text = "Niños: " + objConcierto.nino.ToString();
            lblAdulto.Text = "Adultos: " + objConcierto.adulto.ToString();
            lblTerceraEdad.Text = "Tercera edad: " + objConcierto.tEdad.ToString();
        }
    }
}
