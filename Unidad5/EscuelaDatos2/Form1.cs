using System;
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
    public partial class Form1: Form
    {
        //Contador y objetos.
        int contador = 1; 
        Alumnos Alumno = new Alumnos();
        Docentes Docente = new Docentes();

        public Form1()
        {
            InitializeComponent();
            Alumno.Usuario = new string[102];
            Docente.Usuario = new string[102];
            cmbUsuario.Items.Add("Alumno");
            cmbUsuario.Items.Add("Docente");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Alumno.Usuario.Length!=102)
            {
                if (cmbUsuario.Text == "Alumno")
                {
                    //Estas propiedades sirven para acomodar los datos introducidos según la variable...
                    //...contador.
                    Alumno.Usuario[contador] = cmbUsuario.Text;
                    DatosAlumnos objAlumno = new DatosAlumnos();
                    objAlumno.Show();

                }
                else if (cmbUsuario.Text == "Docente")
                {
                    Docente.Usuario[contador] = cmbUsuario.Text;
                    DatosDocentes objDocentes = new DatosDocentes();
                    objDocentes.Show();
                }
                //El contador va incrementando de 1 en 1.
                contador++;
            }
            else
            {
                if (cmbUsuario.Text == "Alumno")
                {
                    //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                    Alumno.Usuario = new string[100];
                    //Esto sirve para para posicionar el arreglo anterior.
                    Alumno.Usuario[0] = cmbUsuario.Text;
                    DatosAlumnos objAlumno = new DatosAlumnos();
                    objAlumno.Show();
                }
                else if (cmbUsuario.Text == "Docente")
                {
                    //Esto sirve para iniciar otro nuevo arreglo, pero con un límite de 100.
                    Docente.Usuario = new string[100];
                    //Esto sirve para para posicionar el arreglo anterior.
                    Docente.Usuario[0] = cmbUsuario.Text;
                    DatosDocentes objDocentes = new DatosDocentes();
                    objDocentes.Show();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Solamente sirve para cerrar el programa
            Application.Exit();
        }
    }
}
