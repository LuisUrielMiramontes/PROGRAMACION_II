using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapturaDeCalificaciones
{
    public partial class Form1 : Form
    {
        ClassCalificaciones objCalificaciones = new ClassCalificaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            objCalificaciones.calLeida = int.Parse(txtCalif.Text.ToString());
            objCalificaciones.CapturarCalificación();
            txtCalif.Text = "";
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            lblAprobados.Text = "Aprobados: " + objCalificaciones.aprobados.ToString();
            lblReprobados.Text = "Reprobados: " + objCalificaciones.reprobados.ToString();
            lblPromedio.Text = "Promedio: " + objCalificaciones.promedio.ToString();
        }
    }
}
