using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class Form1 : Form
    {
        ClassSuma objSuma = new ClassSuma();
        ClassResta objResta = new ClassResta();
        ClassMultiplicacion objMultiplicacion = new ClassMultiplicacion();
        ClassDivision objDivision = new ClassDivision();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            switch (cboxOperacion.Text)
            {
                case "+":
                    {
                        objSuma = new ClassSuma();
                        objSuma.Valor1 = float.Parse(txtValor1.Text);
                        objSuma.Valor2 = float.Parse(txtValor2.Text);
                        objSuma.Operaciones();
                        txtResultado.Text = Convert.ToString(objSuma.Resultados);
                        break;
                    }
                case "-":
                    {
                        objResta = new ClassResta();
                        objResta.Valor1 = float.Parse(txtValor1.Text);
                        objResta.Valor2 = float.Parse(txtValor2.Text);
                        objResta.Operaciones();
                        txtResultado.Text = Convert.ToString(objResta.Resultados);
                        break;
                    }
                case "*":
                    {
                        objMultiplicacion = new ClassMultiplicacion();
                        objMultiplicacion.Valor1 = float.Parse(txtValor1.Text);
                        objMultiplicacion.Valor2 = float.Parse(txtValor2.Text);
                        objMultiplicacion.Operaciones();
                        txtResultado.Text = Convert.ToString(objMultiplicacion.Resultados);
                        break;
                    }
                case "/":
                    {
                        objDivision = new ClassDivision();
                        objDivision.Valor1 = float.Parse(txtValor1.Text);
                        objDivision.Valor2 = float.Parse(txtValor2.Text);
                        objDivision.Operaciones();
                        txtResultado.Text = Convert.ToString(objDivision.Resultados);
                        break;
                    }
            }
        }
    }
}
