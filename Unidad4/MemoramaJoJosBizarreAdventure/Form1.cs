using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MemoramaJoJosBizarreAdventure
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Lo que este boton hace es abrir la ventana del memorama, pero tiene una condición...
            //...que se necesita introducir el nombre del usuario para poder jugar mediante un...
            //...errorName.
            JuegoMemorama objJuego = new JuegoMemorama();
            if (txtNombre.Text == "")
            {
                errorNombre.SetError(txtNombre, "Introduce tu nombre porfavor");
                txtNombre.Focus();
                return;
            }
            errorNombre.SetError(txtNombre, "");            
            objJuego.lblNombreMemorama.Text = "Jugador: " + txtNombre.Text;
            objJuego.Show();
        }

        private void btnReglas_Click(object sender, EventArgs e)
        {
            //Al igual que el boton "Start", lo que hace es abrir una ventana donde el usuario...
            //...pueda ver las reglas del juego.
            Reglas objReglas = new Reglas();
            objReglas.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Esto solamente cierra el menú del juego.
            Application.Exit();
        }
    }
}
