using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_Restaurante
{
    abstract class ClassEmpleado
    {
        //Atributos
        private string nombre;
        private int fechaNac = 0, diasTrabajados = 0;
        private double sueldo = 0;

        //Propiedades
        public string Nombre
        {
           set {nombre = value;}
           get {return nombre;}
        }
        public int FechaNac
        {
            set {fechaNac = value;}
            get {return fechaNac;}
        }
        public int DiasTrabajados
        {
            set {diasTrabajados = value;}
            get {return diasTrabajados;}
        }
        public double Sueldo
        {
            set {sueldo = value;}
            get {return sueldo;}
        }

        //Constructores
        public ClassEmpleado()
        {
            nombre = "";
            fechaNac = 0;
            diasTrabajados = 0;
            sueldo = 0;
        }

        //Método
        public abstract void CalcularSueldo();
    }
}
