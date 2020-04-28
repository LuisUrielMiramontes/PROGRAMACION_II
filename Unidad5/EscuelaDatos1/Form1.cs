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

namespace DatosAlumnosDocentes
{
    public partial class Form1 : Form
    {
        //Objetos
        Alumnos ObjAlumno = new Alumnos();
        Docentes ObjDocente = new Docentes();

        public Form1()
        {
            InitializeComponent();
            cmbUsuario.Items.Add("Alumno");
            cmbUsuario.Items.Add("Docente");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Esto sirve para validar el textbox "Nombre"
            Regex reNombre = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese un nombre válido");
                txtNombre.Focus();
                return;
            }
            errorProvider1.SetError(txtNombre, "");

            //Esto sirve para validar el textbox "CURP"
            Regex reCurp = new Regex("^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$", RegexOptions.Compiled);

            if (!reCurp.IsMatch(txtCurp.Text))
            {
                errorProvider1.SetError(txtCurp, "Ingrese una curp válida");
                txtCurp.Focus();
                return;
            }
            errorProvider1.SetError(txtCurp, "");

            //Esto sirve para validar el textbox "Teléfono"
            decimal telefono;

            if (!Decimal.TryParse(txtTelefono.Text, out telefono))
            {
                errorProvider1.SetError(txtTelefono, "Debe ingresar números en el campo Teléfono");
                txtTelefono.Focus();
                return;
            }
            errorProvider1.SetError(txtTelefono, "");

            //Esto sirve para validar el textbox "e - mail"
            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                                     + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                                     + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}]"
                                     + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                                     + @"[a-zA-Z]{2,}))$", RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Ingrese una dirección de correo válida");
                txtEmail.Focus();
                return;
            }
            errorProvider1.SetError(txtEmail, "");

            //Aquí se crea una condición si el usuario escoje en el combobox "Alumno", se aplica...
            //...todo esto, donde ademas guarda los datos de la clase usuario.
            if (cmbUsuario.Text == "Alumno")
            {
                ObjAlumno.Nombre = txtNombre.Text;
                ObjAlumno.FechaNac = dtpFechaNac.Value;
                ObjAlumno.Curp = txtCurp.Text;
                ObjAlumno.Telefono = telefono;
                ObjAlumno.email = txtEmail.Text;
                ObjAlumno.Usuario = cmbUsuario.Text;
               
                Alumno objAlumno = new Alumno();
                objAlumno.Show();
            }

            //Aquí se crea una condición si el usuario escoje en el combobox "Docente", se aplica...
            //...todo esto, donde ademas guarda los datos de la clase usuario.
            if (cmbUsuario.Text == "Docente")
            {
                ObjDocente.Nombre = txtNombre.Text;
                ObjDocente.FechaNac = dtpFechaNac.Value;
                ObjDocente.Curp = txtCurp.Text;
                ObjDocente.Telefono = telefono;
                ObjDocente.email = txtEmail.Text;

                Docente objDocente = new Docente();
                objDocente.Show();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Solamente sirve para cerrar el programa
            Application.Exit();
        }
    }
}
