using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculos
{
    public partial class Form1 : Form
    {
        ClassAereo objAereo = new ClassAereo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objAereo.ArranacarMotor(txtSonidoArrancar.Text));
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objAereo.PararMotor(txtSonidoParar.Text));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            objAereo.numeroLlantas = int.Parse(txtLlantas.Text);
            objAereo.numeroPuertas = int.Parse(txtPuertas.Text);
            objAereo.numeroVentanas = int.Parse(txtVentanas.Text);
            objAereo.combustible = (txtCombustible.Text);
            objAereo.color = txtColor.Text;
            objAereo.numeroAlas = int.Parse(txtAlas.Text);
            objAereo.numeroHelices = int.Parse(txtHelices.Text);
            objAereo.numeroTurbinas = int.Parse(txtTurbinas.Text);
            objAereo.tipoAereo = cboxTipoAereo.Text;
            MessageBox.Show("La información del objeto " + objAereo.tipoAereo + " se ha guardado correctamente.");
        }

        private void btnVolar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objAereo.EnVuelo(txtSonidoAereo.Text));
        }
    }
}
