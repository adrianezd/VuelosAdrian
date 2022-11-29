using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VuelosAdrian;

namespace VuelosAdrian
{
    public partial class Entrada : Form
    {
        public static Personas listPers = new Personas();
        public static Billetes listBilletes = new Billetes();
        public static Aeropuertos listAeropuertos = new Aeropuertos();


        public Entrada()
        {
            InitializeComponent();
        }

        private void btLoguear_Click(object sender, EventArgs e)
        {
                if (tbDni.Text == "admin" && tbContrasena.Text == "1234")
                {
                    Menu_administrador a1 = new Menu_administrador();
                    a1.Show();
                    this.Close();
                }
                else if (listPers.DamePersona(tbDni.Text) != null)
                {
                Persona p = listPers.DamePersona(tbDni.Text);
                Console.WriteLine("p ->" + p.ToString());
                if (tbDni.Text == p.Dni && tbContrasena.Text == p.Contrasena)
                {
                    Menu_cliente c1 = new Menu_cliente()
                    {
                        dniCliente = p.Dni
                    };
                    c1.Show();
                    this.Close();
                }
                else { MessageBox.Show("Introduce de nuevo las credenciales, dep"); }

                }
                else
                {
                    MessageBox.Show("Introduce de nuevo las credenciales, inutil");
                }
        }


        private void Entrada_Load(object sender, EventArgs e)
        {
           
            Persona p1 = new Persona("Adrian","Ezquerro","Beratua","11111111A", "0");
            Persona p2 = new Persona("Lucas", "Fernandez", "Trinidad", "11111111B", "0");
            Persona p3 = new Persona("Javier", "Olalla", "Trinidadd", "11111111C", 7);
            Vuelo v1 = new Vuelo("Madrid","Barcelona",DateTime.MinValue);
            Vuelo v2 = new Vuelo("Madrid", "Sevilla", DateTime.MaxValue);
            Billete b1 = new Billete(p1, v1);
            Billete b2 = new Billete(p2, v2);
            Billete b3 = new Billete(p2, v1);
            Billete b4 = new Billete(p1, v2);
            listPers.Anadir_persona(p1);
            listPers.Anadir_persona(p2);
            listPers.Anadir_persona(p3);
            Console.WriteLine("la contra es " + p3.Contrasena);
            listBilletes.Anadir_billete(b1);
            listBilletes.Anadir_billete(b2);
            listBilletes.Anadir_billete(b3);
            Aeropuerto a1 = new Aeropuerto("Madrid");
            Aeropuerto a2 = new Aeropuerto("Barcelona");
            Aeropuerto a3 = new Aeropuerto("Bilbao");
            Aeropuerto a4 = new Aeropuerto("Valencia");
            listAeropuertos.Anadir_Aeropuerto(a1);listAeropuertos.Anadir_Aeropuerto(a2);listAeropuertos.Anadir_Aeropuerto(a3);listAeropuertos.Anadir_Aeropuerto(a4);
        }
    }
}
