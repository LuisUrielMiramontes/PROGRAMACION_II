using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasetaDeAutopista
{
    public partial class Form1 : Form
    {
        ClassVehiculo objVehiculo = new ClassVehiculo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCobrar_Click(object sender, EventArgs e)
        {
            objVehiculo.tipo = (cmbCategoria.Text.ToString());
            objVehiculo.Caseta();
            lblTotal.Text = "Cobro total: $" + objVehiculo.cobro.ToString();

        }
    }
}
