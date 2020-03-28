using System;
using System.Collections;
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
    public partial class JuegoMemorama : Form
    {
        //Objetos: Para poder programar los botones, primero se necesita crear los objetos...
        //...donde se guardan los datos para así, poder mandar llamar las propiedades de las...
        //...clases e interfaces creadas, aunque aquí se pueden crear otro tipo de datos...
        //...como los "List<string>", "ArrayList" y "PictureBox" que sirven para poder guardar...
        //...imagenes y listas ya que se necesitan para poder realizar el memorama.
        Memorama objMemorama = new Memorama();
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        public JuegoMemorama()
        {
            //Aquí es donde comienza el codigo para hacer funcionar el juego.
            InitializeComponent();
            iniciarJuego();
        }
        public void iniciarJuego()
        {
            //Aquí se tienen que mandar a llamar los objetos creados junto con algunas...
            //...propiedades, para así guardarlos y crear varias combinaciones revueltas de cartas...
            //con el fin de no tener el mismo patron repetido del memorama.
            objMemorama.TamanioColumnasFilas = 4;
            timer1.Enabled = false;
            timer1.Stop();
            lblNumeroRecord.Text = "0";
            objMemorama.CantidadDeCarasVolteadas = 0;
            objMemorama.Movimientos= 0;
            panelMemorama.Controls.Clear();
            objMemorama.CantidadDeCarasVolteadas = 0;
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();
            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            //Aquí es donde se acomoda el tamaño de las cartas para así evitar complicaciones...
            //...de espacio en el WindowsForm.
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = objMemorama.TamanioColumnasFilas;
            tablaPanel.ColumnCount = objMemorama.TamanioColumnasFilas;
            for (int i = 0; i < objMemorama.TamanioColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)objMemorama.TamanioColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            //Lo que hace esta parte del codigo es crear el contador de clicks que el...
            //...usuario hace al momento de jugar (Record) y a la vez, predeterminar el...
            //...formato de la carta cuando esta sin voltear.
            objMemorama.ContadorFichas = 1;
            for (var i = 0; i < objMemorama.TamanioColumnasFilas; i++)
            {
                for (var j = 0; j < objMemorama.TamanioColumnasFilas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", objMemorama.ContadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.Girada;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    objMemorama.ContadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            panelMemorama.Controls.Add(tablaPanel);
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //Esto solamente reinicia el juego.
            iniciarJuego();
        }
        private void btnCarta_Click(object sender, EventArgs e)
        {
            //En esta parte se muestra el codigo cuando el usuario le da click a una carta y...
            //...muestra la imagen del personaje y lo que ocurre si obtiene el par o no.
            if (CartasSeleccionadas.Count < 2)
            {
                objMemorama.Movimientos++;
                lblNumeroRecord.Text = Convert.ToString(objMemorama.Movimientos);
                var CartasSeleccionadasUsuario = (PictureBox)sender;

                objMemorama.CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) -1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagen(objMemorama.CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);

                //En este parte se muestra cuando el usuario realice el evento click 2 veces.
                if (CartasSeleccionadas.Count == 2)
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) -1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) -1]);

                    //Aquí se activa un timer.
                    if (Carta1 != Carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        objMemorama.CantidadDeCarasVolteadas++;

                        //En esta parte del codigo lo que hace es mandarle un mensaje al usuario...
                        //...al momento de ganar el juego.
                        if (objMemorama.CantidadDeCarasVolteadas > 7)
                        {
                            MessageBox.Show("Eccellente ¡Di Molto!");
                        }
                        CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();
                    }
                }
            }
        }
        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            //Esto solamente almacena las imagenes de las cartas del juego en la...
            //...carpeta "Resources" con el fin de implementarlas en el memorama.
            Bitmap TmpImg = new Bitmap(200, 100);
            switch (NumeroImagen)
            {
                case 0: TmpImg = Properties.Resources.img8;
                    break;
                default: TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + NumeroImagen);
                    break;
            }
            return TmpImg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Lo que esto hace es mediante un timer, al momento de que el usuario de click...
            //...a una carta, este lo pueda ver y memorizar por unos segundos.
            objMemorama.TiempoVirarCarta = 1;
            {
                if (objMemorama.TiempoVirarCarta == 1)
                CartaTemporal1.Image = Properties.Resources.Girada;
                CartaTemporal2.Image = Properties.Resources.Girada;
                CartasSeleccionadas.Clear();
                objMemorama.TiempoVirarCarta = 0;
                timer1.Stop();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelMemorama_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Solamente es un boton para cerrar el juego.
            this.Dispose();
        }
    }
}
