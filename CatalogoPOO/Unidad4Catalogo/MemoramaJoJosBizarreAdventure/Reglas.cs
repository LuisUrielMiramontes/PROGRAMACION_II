using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoramaJoJosBizarreAdventure
{
    public partial class Reglas : Form
    {
        public Reglas()
        {
            InitializeComponent();
        }

        private void Reglas_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Solamente cierra la ventana de reglas
            this.Dispose();
        }
    }
}
