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
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
        }
        Auto auto = new Auto();
        Moto moto = new Moto();
        Bus bus = new Bus();
        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            // Guardando los productos por defecto
            auto.Lista.Add(new Auto(1, "Auto", "Land Cruiser D-4D VX Aut. - 5-puertas - 2020", "Automático 204CV", "Toyota", "4 Personas", 495.000,2020));
            auto.Lista.Add(new Auto(2, "Auto", "Civic Sedán 1.5 VTEC Turbo Elegance CVT - 4-puertas - 2019", "Automático 182CV", "Honda", "4 Personas", 30.625, 2019));
            auto.Lista.Add(new Auto(3, "Auto", "330dA Touring (4.75) - 5-puertas - 2020", "Automatico 286CV", "BMW", "4 Personas", 22.000, 2020));
            moto.Lista.Add(new Moto(4, "Moto", "HONDA X-ADV 2021", "Manual  57.8CV", "Honda", "2 Personas", 22.000, 2021));
            moto.Lista.Add(new Moto(5, "Moto", "YAMAHA MT-07 2021", "Manual 73.4CV", "Yamaha", "2 Personas", 30.000, 2021));
            moto.Lista.Add(new Moto(6, "Moto", "KAWASAKI NINJA 400 2020", "Manual 45CV", "Kawasaki", "2 Personas", 40.000, 2020));
            moto.Lista.Add(new Moto(7, "Moto", "BMW R 18 2021", "Manual 91CV", "BMW", "1 Persona", 20.000, 2021));
            bus.Lista.Add(new Bus(8, "Bus", "ELF 600 Bus", "Manual 300CV", "Isuzu", "35 Personas", 150.000, 2011));
            bus.Lista.Add(new Bus(9, "Bus", "9800 2017", "Manual 320CV", "Volvo", "45 Personas", 100.000, 2017));
            bus.Lista.Add(new Bus(10, "Bus", "Paradiso 1200", "Manual 300CV ", "Mercedez Benz", "40 Personas", 100.000, 2015));

        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
                    dataGridView1.DataSource = auto.Lista;
                    dataGridView1.DataSource = moto.Lista;
                    dataGridView1.DataSource = bus.Lista;
                }
                else if(busqueda.Equals("auto"))
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre del 
                    dataGridView1.DataSource = auto.Lista.FindAll(x => x.Marca.ToString().ToLower() == busqueda || x.Modelo.ToLower() == busqueda);
                }
                else if (busqueda.Equals("moto"))
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = moto.Lista.FindAll(x => x.Marca.ToString().ToLower() == busqueda || x.Modelo.ToLower() == busqueda);
                }
                else if (busqueda.Equals("bus"))
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = bus.Lista.FindAll(x => x.Marca.ToString().ToLower() == busqueda || x.Modelo.ToLower() == busqueda);
                }
                else
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = auto.Lista.FindAll(x => x.Marca.ToString().ToLower() == busqueda || x.Modelo.ToLower() == busqueda);
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = moto.Lista.FindAll(x => x.Marca.ToString().ToLower() == busqueda || x.Modelo.ToLower() == busqueda);
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre 
                    dataGridView1.DataSource = bus.Lista.FindAll(x => x.Marca.ToString().ToLower() == busqueda || x.Modelo.ToLower() == busqueda);
                }

            }
        }
    }
}
