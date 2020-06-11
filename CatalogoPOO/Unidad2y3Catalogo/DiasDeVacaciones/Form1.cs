using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiasDeVacaciones
{
    public partial class Form1 : Form
    {
        ClassEmpleado objVacaciones = new ClassEmpleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblDias.Text = "Número de días: ";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            objVacaciones.aniosTrabajados = int.Parse(txtAnios.Text);
            objVacaciones.DiasDeVacaciones();
            lblDias.Text = "Número de días: " + objVacaciones.diasVacaciones.ToString();
            txtAnios.Text = "";

        }
    }
}
