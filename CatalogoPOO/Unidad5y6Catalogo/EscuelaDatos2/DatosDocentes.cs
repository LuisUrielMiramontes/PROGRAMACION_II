using System;
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

namespace EscuelaDatos2
{
    public partial class DatosDocentes : Form
    {
        //Contador
        int contador = 1;
        //Objeto "Docente"
        Docentes Docente = new Docentes();
        StreamWriter objDatos;
        string almacenar = "";
        public DatosDocentes()
        {
            InitializeComponent();
            //Esto sirve para limitar el arreglo (un límite)
            Docente.Nombre = new string[102];
            Docente.FechaNac = new DateTime[102];
            Docente.Curp = new string[102];
            Docente.Telefono = new decimal[102];
            Docente.email = new string[102];
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

            //Esto sirve para validar el textbox "Número de docente"
            Regex reNumDocente = new Regex("[0-9]{1,9}(/.[0-9]{0,2})?$", RegexOptions.Compiled);

            if (!reNumDocente.IsMatch(txtNumDoc.Text))
            {
                errorProvider1.SetError(txtNumDoc, "Ingrese números en el campo número de docente");
                txtNumDoc.Focus();
                return;
            }
            errorProvider1.SetError(txtNumDoc, "");

            //Esto sirve para validar el textbox "Sueldo"
            decimal sueldo;

            if (!Decimal.TryParse(txtSueldo.Text, out sueldo))
            {
                errorProvider1.SetError(txtSueldo, "Ingrese números en el campo sueldo");
                txtSueldo.Focus();
                return;
            }
            errorProvider1.SetError(txtSueldo, "");

            if (sueldo < 0)
            {
                errorProvider1.SetError(txtSueldo, "Ingrese números positivos");
                txtSueldo.Focus();
                return;
            }

            //Esto sirve para validar el textbox "Materias que imparte"
            Regex reMImparte = new Regex("[a-zA-ZñÑ/s]", RegexOptions.Compiled);

            if (!reMImparte.IsMatch(txtMateriasImp.Text))
            {
                errorProvider1.SetError(txtMateriasImp, "Ingrese materia que imparte válida");
                txtMateriasImp.Focus();
                return;
            }
            errorProvider1.SetError(txtMateriasImp, "");

            //Esto sirve para poder restringir el arreglo si se pasa de 102.
            if (Docente.Nombre.Length != 102)
            {
                //Estas propiedades sirven para acomodar los datos introducidos según la variable...
                //...contador.
                Docente.Nombre[contador] = txtNombre.Text;
                Docente.FechaNac[contador] = dtpFechaNac.Value;
                Docente.Curp[contador] = txtCurp.Text;
                Docente.Telefono[contador] = telefono;
                Docente.email[contador] = txtEmail.Text;
                Docente.NumeroMaes[contador] = int.Parse(txtNumDoc.Text);
                Docente.Sueldo[contador] = sueldo;
                Docente.MateriasImparte[contador] = txtMateriasImp.Text;
                //Método: Esto sirve para cuando se guarden datos los ingresados, aclara todos los...
                //...textbox.
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNumDoc.Clear();
                txtSueldo.Clear();
                txtMateriasImp.Clear();
            }
            else
            {
                //En esta sección se crean los arreglos de los textbox.
                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Docente.Nombre = new string[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Docente.Nombre[0] = txtNombre.Text;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Docente.FechaNac = new DateTime[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Docente.FechaNac[0] = dtpFechaNac.Value;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Docente.Curp = new string[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Docente.Curp[0] = txtCurp.Text;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Docente.Telefono = new decimal[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Docente.Telefono[0] = telefono;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Docente.email = new string[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Docente.email[0] = txtEmail.Text;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Docente.NumeroMaes = new int[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Docente.NumeroMaes[0] = int.Parse(txtNumDoc.Text);

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Docente.Sueldo = new decimal[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Docente.Sueldo[0] = sueldo;

                //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                Docente.MateriasImparte = new string[100];
                //Esto sirve para para posicionar el arreglo anterior.
                Docente.MateriasImparte[0] = txtMateriasImp.Text;
                //Aquí se crea un método para limpiar los textbox
                txtNombre.Clear();
                txtCurp.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                txtNumDoc.Clear();
                txtSueldo.Clear();
                txtMateriasImp.Clear();
            }
            almacenar += Docente.Nombre[0] + " ";
            almacenar += Docente.FechaNac[0] + " ";
            almacenar += Docente.Curp[0] + " ";
            almacenar += Docente.Telefono[0] + " ";
            almacenar += Docente.email[0] + " ";
            almacenar += Docente.Sueldo[0] + " ";
            almacenar += Docente.MateriasImparte[0] + " ";
            objDatos = new StreamWriter("DatosDocentes.txt");
            objDatos.Write(almacenar);
            objDatos.Close();
        }

        private void tsbImprimir_Click(object sender, EventArgs e)
        {
            //Aquí se crea un método para limpiar los datos del dataGridView.
            dgvDatosDocentes.Rows.Clear();

            //Este es un ciclo "for" que se cumplira siempre y cuando la "i", sea menor a la...
            //...tamaño límite del arreglo.
            for (int i = 0; i < Docente.Nombre.Length; i++)
            {
                //Si el ciclo "for" se cumple, entra a esta condición que se cumplirá...
                //...siempre y cuando la posicion del arreglo "Nombre" no tenga nada y el arreglo...
                //..."Teléfono" sea diferente a 0.
                if (Docente.Nombre[i] != "" && Docente.Telefono[i] != 0)
                {
                    //Esto sirve para acomodar el arreglo al dataGridView.
                    dgvDatosDocentes.Rows.Add(Docente.Nombre[i], Docente.FechaNac[i], Docente.Curp[i], Docente.Telefono[i], Docente.email[i], Docente.NumeroMaes[i], Docente.Sueldo[i], Docente.MateriasImparte[i]);

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
