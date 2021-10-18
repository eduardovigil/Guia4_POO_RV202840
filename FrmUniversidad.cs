using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia4_POO_RV22840
{
    public partial class FrmUniversidad : Form
    {
        public FrmUniversidad()
        {
            InitializeComponent();
        }
        Alumno alumn = new Alumno();
        Universitario uni = new Universitario();
        Ingenieria inge = new Ingenieria();

        private void FrmUniversidad_Load(object sender, EventArgs e)
        {
            alumn.Listass.Add(new Alumno("Jose Mejilla", "Mejia@hotmail.com", "2536-8596", 19, 202523, 40));
            uni.Listass.Add(new Universitario("Jose Mejilla", "Mejia@hotmail.com", "2536-8596", 19, "Universidad Benito", "Ingenieria en contabilidad", 4, 9, 8));
            inge.Listass.Add(new Ingenieria("Jose Mejilla", "Mejia@hotmail.com", "2536-8596", 19, "Especializacion contable", 952, 56));
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos ingresados en el textbox
            string busqueda = textBox1.Text;

            busqueda = busqueda.ToLower(); //Los hacemos en minusculas, para luego trabajar todo en minusculas

            if (busqueda.Equals("")) //Si no se ingresaron datos, devolver error
            {
                MessageBox.Show("Ingresa un dato en la búsqueda.");
            }
            else
            {

                if (busqueda.Equals("todos")) // Si la busqueda es igual a todos, mostramos todos los datos
                {
                    dataGridView1.DataSource = alumn.Lista;
                    dataGridView1.DataSource = uni.Lista;
                    dataGridView1.DataSource = inge.Lista;
                }
                else if (busqueda.Equals("alumno"))
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre del 
                    dataGridView1.DataSource = alumn.Lista.FindAll(x => x.Nombres.ToString().ToLower() == busqueda || x.Correo.ToLower() == busqueda);
                }
                else if (busqueda.Equals("universitario"))
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = uni.Lista.FindAll(x => x.Nombres.ToString().ToLower() == busqueda || x.Telefono.ToLower() == busqueda);
                }
                else if (busqueda.Equals("ingenieria"))
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = inge.Lista.FindAll(x => x.Nombres.ToString().ToLower() == busqueda || x.Correo.ToLower() == busqueda);
                }
                else
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = alumn.Lista.FindAll(x => x.Nombres.ToString().ToLower() == busqueda || x.Correo.ToLower() == busqueda);
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = uni.Lista.FindAll(x => x.Nombres.ToString().ToLower() == busqueda || x.Telefono.ToLower() == busqueda);
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = inge.Lista.FindAll(x => x.Nombres.ToString().ToLower() == busqueda || x.Correo.ToLower() == busqueda);
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form Menu = new FrmMenu();
            Menu.Show();
            this.Hide();
        }
    }
}
