using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Embotelladora
{
    public partial class frm : Form
    {
        ClassBotella objBotella = new ClassBotella();
        public frm()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            objBotella.nivelLlenado = int.Parse(txtNivelLlenado.Text);
            objBotella.verificarLlenado();
            lblResultado.Text = "Resultados: " + objBotella.mililitrosVerificados.ToString();
        }
    }
}
