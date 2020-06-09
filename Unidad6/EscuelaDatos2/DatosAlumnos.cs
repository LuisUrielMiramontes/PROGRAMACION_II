using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatosAlumnosDocentes
{
    public partial class DatosAlumnos : Form
    {
        //Contador
        int contador = 1;

        //Objeto "Alumno"
        Alumnos Alumno = new Alumnos();
        StreamWriter objDatos;
        string almacenar = "";
        public DatosAlumnos()
        {
            //Esto sirve para limitar el arreglo (un límite)
            Alumno.Nombre = new string[102];
            Alumno.FechaNac = new DateTime[102];
            Alumno.Curp = new string[102];
            Alumno.Telefono = new decimal[102];
            Alumno.email = new string[102];
            Alumno.NumControl = new int[102];
            Alumno.Carrera = new string[102];
            Alumno.Materia = new string[102];
            Alumno.Calificacion = new double[102];

            InitializeComponent();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
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

            //Esto sirve para validar el textbox "Número de control"
            Regex reNumControl = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumControl.IsMatch(txtNumControl.Text))
            {
                errorProvider1.SetError(txtNumControl, "Ingrese números en el campo número de control");
                txtNumControl.Focus();
                return;
            }
            errorProvider1.SetError(txtNumControl, "");

            //Esto sirve para validar el textbox "Carrera"
            Regex reCarrera = new Regex("[a-zA-ZñÑ/s]", RegexOptions.Compiled);

            if (!reCarrera.IsMatch(txtCarrera.Text))
            {
                errorProvider1.SetError(txtCarrera, "Ingrese una carrera válida");
                txtCarrera.Focus();
                return;
            }
            errorProvider1.SetError(txtCarrera, "");

            //Validación de la caja de texto Materia
            Regex reMateria = new Regex("[a-zA-ZñÑ/s]{2,50}", RegexOptions.Compiled);

            if (!reMateria.IsMatch(txtMateria.Text))
            {
                errorProvider1.SetError(txtMateria, "Ingrese una materia válida");
                txtMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtMateria, "");

            //Esto sirve para validar el textbox "Calificación de la materia"
            Regex reCalificacion = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (txtCalMateria.Text == "")
            {
                errorProvider1.SetError(txtCalMateria, "Ingrese una calificación válida");
                txtCalMateria.Focus();
                return;
            }
            errorProvider1.SetError(txtCalMateria, "");

            //Esto sirve para poder restringir el arreglo si se pasa de 102.
            if (Alumno.Nombre.Length != 102)
            {
                //Estas propiedades sirven para acomodar los datos introducidos según la variable...
                //...contador.
                Alumno.Nombre[contador] = txtNombre.Text;
                Alumno.FechaNac[contador] = dtpFechaNac.Value;
                Alumno.Curp[contador] = txtCurp.Text;
                Alumno.Telefono[contador] = telefono;
                Alumno.email[contador] = txtEmail.Text;
                Alumno.NumControl[contador] = int.Parse(txtNumControl.Text);
                Alumno.Carrera[contador] = txtCarrera.Text;
                Alumno.Materia[contador] = txtMateria.Text;
                Alumno.Calificacion[contador] = double.Parse(txtCalMateria.Text);

                //Método: Esto sirve para cuando se guarden datos los ingresados, aclara todos los...
                //...textbox.
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNumControl.Clear();
                txtCarrera.Clear();
                txtMateria.Clear();
                txtCalMateria.Clear();
                //El contador va incrementando de 1 en 1.
                contador++;
            }
            else
            {
                //En esta sección se crean los arreglos de los textbox.
                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Alumno.Nombre = new string[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Alumno.Nombre[0] = txtNombre.Text;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Alumno.FechaNac = new DateTime[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Alumno.FechaNac[0] = dtpFechaNac.Value;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Alumno.Curp = new string[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Alumno.Curp[0] = txtCurp.Text;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Alumno.Telefono = new decimal[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Alumno.Telefono[0] = telefono;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Alumno.email = new string[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Alumno.email[0] = txtEmail.Text;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Alumno.NumControl = new int[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Alumno.NumControl[0] = int.Parse(txtNumControl.Text);

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Alumno.Carrera = new string[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Alumno.Carrera[0] = txtCarrera.Text;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Alumno.Materia = new string[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Alumno.Materia[0] = txtMateria.Text;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Alumno.Calificacion = new double[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Alumno.Calificacion[0] = double.Parse(txtCalMateria.Text);

                //Aquí se crea un método para limpiar los textbox.
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNumControl.Clear();
                txtCarrera.Clear();
                txtMateria.Clear();
                txtCalMateria.Clear();
            }
            almacenar += Alumno.Nombre[0] + " ";
            almacenar += Alumno.FechaNac[0] + " ";
            almacenar += Alumno.Curp[0] + " ";
            almacenar += Alumno.Telefono[0] + " ";
            almacenar += Alumno.email[0] + " ";
            almacenar += Alumno.NumControl[0] + " ";
            almacenar += Alumno.Carrera[0] + " ";
            almacenar += Alumno.Materia[0] + " ";
            almacenar += Alumno.Calificacion[0] + " ";
            objDatos = new StreamWriter("DatosAlumnos.txt");
            objDatos.Write(almacenar);
            objDatos.Close();
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            //Aquí se crea un método para limpiar los datos del dataGridView.
            dgvDatosAlumno.Rows.Clear();

            //Este es un ciclo "for" que se cumplira siempre y cuando la "i", sea menor a la...
            //...tamaño límite del arreglo.
            for (int i = 0; i < Alumno.Nombre.Length; i++)
            {
                //Si el ciclo "for" se cumple, entra a esta condición que se cumplirá...
                //...siempre y cuando la posicion del arreglo "Nombre" no tenga nada y el arreglo...
                //..."Teléfono" sea diferente a 0. 
                if (Alumno.Nombre[i] != "" && Alumno.Telefono[i] != 0)
                {
                    //Esto sirve para acomodar el arreglo al dataGridView.
                    dgvDatosAlumno.Rows.Add(Alumno.Nombre[i], Alumno.FechaNac[i], Alumno.Curp[i], Alumno.Telefono[i], Alumno.email[i], Alumno.NumControl[i], Alumno.Carrera[i], Alumno.Materia[i], Alumno.Calificacion[i]);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Solamente sirve para cerrar el programa
            this.Close();
        }
    }
}
