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
    public class Alumno: Estudiante
    {
        int nCarnet;
        public int Carnet
        {
            get { return nCarnet; }
            set { nCarnet = value; }
        }
        int nivelestudio;
        public int NivelEstudio
        {
            get { return nivelestudio; }
            set { nivelestudio = value; }
        }
    }
    public class Universitario:Estudiante
    {
        string nombreu;
        public string NombreU
        {
            get { return nombreu; }
            set { nombreu = value; }
        }
        string carrera;
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        int materias;
        public int Materias {
            get { return materias; }
            set { materias = value; }
        }
        int notas;
        public int Notas
        {
            get { return notas; }
            set { notas = value; }
        }
        int cum;
        public int CUM
        {
            get { return cum; }
            set { cum = value; }
        }
    }
    public class Ingenieria : Estudiante
    {
        string nombreproyecto;
        public string Nombreproyecto
        {
            get { return nombreproyecto; }
            set { nombreproyecto = value; }
        }
        decimal totahora;
        public decimal Horastotal
        {
            get { return totahora; }
            set { totahora = value; }
        }
        decimal horacompletas;
        public decimal Horascompletas
        {
            get { return horacompletas; }
            set { horacompletas = value; }
        }
    }
}
