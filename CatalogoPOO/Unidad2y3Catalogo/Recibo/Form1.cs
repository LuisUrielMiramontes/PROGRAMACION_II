using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recibo
{
    public partial class Form1 : Form
    {
        ClassRecibo objRecibo = new ClassRecibo();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblContrat.Text = "Contrato: ";
            lblRecibo.Text = "Recibo: ";
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            objRecibo.kw = Convert.ToDouble(txtKilowats.Text);
            objRecibo.tipo = (cboxContrato.Text.ToString());
            objRecibo.cobro();
            lblRecibo.Text = "Recibo: " + objRecibo.tipo.ToString();
            lblContrat.Text = "Contrato: " + objRecibo.pago.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
