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
        ClassEmpleados objVacaciones = new ClassEmpleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            objVacaciones.aniosTrabajados = int.Parse(txtAnios.Text.ToString());
            objVacaciones.DiasDeVacaciones();
            lblDias.Text = "Días de vacaciones correspondidos: " + objVacaciones.diasVacaciones.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
