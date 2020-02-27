using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorDeEdad
{
    public partial class Form1 : Form
    {
        ClassPersona objMayorDeEdad = new ClassPersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            objMayorDeEdad.anioAct = int.Parse(DateTime.Today.Year.ToString());
            objMayorDeEdad.mesAct = int.Parse(DateTime.Today.Month.ToString());
            objMayorDeEdad.diaAct = int.Parse(DateTime.Today.Day.ToString());
            objMayorDeEdad.anioNac = int.Parse(dtpNacimiento.Value.Year.ToString());
            objMayorDeEdad.mesNac = int.Parse(dtpNacimiento.Value.Month.ToString());
            objMayorDeEdad.diaNac = int.Parse(dtpNacimiento.Value.Day.ToString());
            objMayorDeEdad.MayoresDeEdad();
            lblMayor.Text = "Persona: " + objMayorDeEdad.mayorEdad;
            objMayorDeEdad.mayorEdad = int.Parse(dtpNacimiento.Text());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblMayor.Text = "Persona: ";
        }
    }
}
