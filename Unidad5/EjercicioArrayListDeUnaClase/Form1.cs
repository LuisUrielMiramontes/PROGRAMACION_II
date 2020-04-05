using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioArrayListDeUnaClase
{
    public partial class Form1 : Form
    {
        ArrayList Personas = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Persona Persona1 = new Persona();
            Persona1.ID = "348754";
            Persona1.Nombres = "Giorno";
            Persona1.Apellidos = "Giovanna";
            Persona1.Correo = "giogio@hotmail.com";
            Persona1.FechaNacimiento = new DateTime(1986, 7, 23);
            Persona1.Salario = 350000;
            Personas.Add(Persona1);

            Persona Persona2 = new Persona();
            Persona2.ID = "234568";
            Persona2.Nombres = "Bruno";
            Persona2.Apellidos = "Brucciarati";
            Persona2.Correo = "stickyfingaaars@yahoo.com";
            Persona2.FechaNacimiento = new DateTime(1975, 6, 13);
            Persona2.Salario = 450000;
            Personas.Add(Persona2);

            dgvDatos.DataSource = Personas;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Debe ingresar el ID de la persona");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");

            if (Existe(txtID.Text))
            {
                errorProvider1.SetError(txtID, "ID empleado ya ha sido registrado");
                txtID.Focus();
                return;
            }
            errorProvider1.SetError(txtID, "");
        
            if (txtNombres.Text == "")
            {
                errorProvider1.SetError(txtNombres, "Debe ingresar nombre(s) de la persona");
                txtNombres.Focus();
                return;
            }
            errorProvider1.SetError(txtNombres, "");

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "Debe ingresar apellido(s) de la persona");
                txtApellidos.Focus();
                return;
            }
            errorProvider1.SetError(txtApellidos, "");

            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                    + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                    + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                    + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                    + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "Debe ingresar una dirección de correo válida");
                txtCorreo.Focus();
                return;
            }
            errorProvider1.SetError(txtCorreo, "");

            decimal Salario;
            if (!Decimal.TryParse(txtSalario.Text, out Salario))
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar números en el campo salario");
                txtSalario.Focus();
                return;
            }
            if (Salario < 0)
            {
                errorProvider1.SetError(txtSalario, "Debe ingresar números positivos en el campo salario");
                txtSalario.Focus();
                return;
            }
            Persona MiPersona = new Persona();
            MiPersona.ID = txtID.Text;
            MiPersona.Nombres = txtNombres.Text;
            MiPersona.Apellidos = txtApellidos.Text;
            MiPersona.Correo = txtCorreo.Text;
            MiPersona.FechaNacimiento = dtpFechaNac.Value;
            MiPersona.Salario = Salario;
            Personas.Add(MiPersona);

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = Personas;

            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtSalario.Clear();
            txtID.Focus();
        }

        private bool Existe(string ID)
        {
            foreach (Persona Persona in Personas)
            {
                if (Persona.ID == ID) return true;
            }
            return false;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
