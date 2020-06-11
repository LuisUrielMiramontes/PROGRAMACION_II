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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnidad1_Click(object sender, EventArgs e)
        {
            CatalogoUnidad1 objUnidad1 = new CatalogoUnidad1();
            objUnidad1.Show();
        }

        private void btnUnidad2y3_Click(object sender, EventArgs e)
        {
            btnCatalogoUnidad2y3 objUnidad2y3 = new btnCatalogoUnidad2y3();
            objUnidad2y3.Show();
        }

        private void btnUnidad4_Click(object sender, EventArgs e)
        {
            CatalogoUnidad4 objUnidad4 = new CatalogoUnidad4();
            objUnidad4.Show();
        }

        private void btnUnidad5_Click(object sender, EventArgs e)
        {
            CatalogoUnidad5 objUnidad5 = new CatalogoUnidad5();
            objUnidad5.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUnidad6_Click(object sender, EventArgs e)
        {
            CatalogoUnidad6 objUnidad6 = new CatalogoUnidad6();
            objUnidad6.Show();
        }
    }
}
