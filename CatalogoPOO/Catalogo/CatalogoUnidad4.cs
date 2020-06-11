using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class CatalogoUnidad4 : Form
    {
        public CatalogoUnidad4()
        {
            InitializeComponent();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos.Form1 Vehiculos = new Vehiculos.Form1();
            Vehiculos.Show();
        }

        private void btnOperaciones_Click(object sender, EventArgs e)
        {
            Operaciones.Form1 Operaciones = new Operaciones.Form1();
            Operaciones.Show();
        }

        private void btnFigurasGeometricas_Click(object sender, EventArgs e)
        {
            Figuras.Form1 Figuras = new Figuras.Form1();
            Figuras.Show();
        }

        private void btnInterfaceMaquinaExpendedora_Click(object sender, EventArgs e)
        {
            InterfaceMaquinaExpendedora.Form1 InterfaceMaquinaExpendedora = new InterfaceMaquinaExpendedora.Form1();
            InterfaceMaquinaExpendedora.Show();
        }

        private void btnEmpleadosRestaurante_Click(object sender, EventArgs e)
        {
            Empleados_Restaurante.Form1 EmpleadosRestaurante = new Empleados_Restaurante.Form1();
            EmpleadosRestaurante.Show();
        }

        private void btnMemoramaJoJosBizarreAdventure_Click(object sender, EventArgs e)
        {
            MemoramaJoJosBizarreAdventure.Menu MemoramaJoJosBizarreAdventure = new MemoramaJoJosBizarreAdventure.Menu();
            MemoramaJoJosBizarreAdventure.Show();
        }

        private void btnRegresarUnidad4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
