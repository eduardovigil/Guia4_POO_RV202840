using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia4_POO_RV22840
{
    public class Estudiantes
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string correo;
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        string telefono;
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }

}
