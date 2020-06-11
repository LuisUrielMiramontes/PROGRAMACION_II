using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados_Restaurante
{
    public partial class Form1 : Form
    {
        //Objetos
        Mesero objMesero = new Mesero();
        Repartidor objRepartidor = new Repartidor();
        Cajero objCajero = new Cajero();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalarioMesero_Click(object sender, EventArgs e)
        {
            objMesero.Nombre = Convert.ToString(txtNombreMesero.Text);
            DateTime FechaNac = dtpFechaMesero.Value;
            objMesero.Propina = Convert.ToDouble(txtPropinaMesero.Text);
            objMesero.DiasTrabajados = int.Parse(cmbDiasMesero.Text);
            objMesero.Sueldo = Convert.ToDouble(txtSueldoMesero.Text);
            objMesero.CalcularSueldo();
            MessageBox.Show(objMesero.Nombre + " nacido el " + FechaNac + " ganó " + "$" + objMesero.SueldoSemana);
        }

        private void btnSalarioRepartidor_Click(object sender, EventArgs e)
        {
            objRepartidor.Nombre = Convert.ToString(txtNombreRepartidor.Text);
            DateTime FechaNac = dtpFechaRepartidor.Value;
            objRepartidor.PropinaSemana = Convert.ToDouble(txtPropinaRepartidor.Text);
            objRepartidor.DiasTrabajados = int.Parse(cmbDiasRepartidor.Text);
            objRepartidor.ZonaReparto = Convert.ToString(cmbZonaRepartidor.Text);
            objRepartidor.TotalAbonos = int.Parse(txtAbonosRepartidor.Text);
            objRepartidor.SueldoRep = Convert.ToDouble(txtSueldoRepartidor.Text);
            objRepartidor.CalcularSueldo();
            MessageBox.Show(objRepartidor.Nombre + " nacido el " + FechaNac + " ganó " + "$" + objRepartidor.SueldoRep);
        }

        private void btnSalarioCajero_Click(object sender, EventArgs e)
        {
            objCajero.Nombre = Convert.ToString(txtNombreCajero.Text);
            DateTime FechaNac = dtpFechaCajero.Value;
            objCajero.NumeroCaja = Convert.ToString(cmbNumeroCaja.Text);
            objCajero.DiasTrabajados = int.Parse(cmbDiasCajero.Text);
            objCajero.Sueldo = Convert.ToDouble(txtSueldoCajero.Text);
            objCajero.CalcularSueldo();
            MessageBox.Show(objCajero.Nombre + " nacido el " + FechaNac + " ganó " + "$" + objCajero.SueldoSemanal);
        }
    }
}
