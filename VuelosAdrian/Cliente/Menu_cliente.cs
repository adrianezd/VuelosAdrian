using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuelosAdrian
{
    public partial class Menu_cliente : Form
    {
        public string dniCliente = string.Empty;
        public Menu_cliente()
        {
            InitializeComponent();
        }

        private void btComprarBillete_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btVervuelo_Click(object sender, EventArgs e)
        {
            if(tbBuscarVuelo.Text != null)
            {

                Billete b = Entrada.listBilletes.Buscar_id(Int32.Parse(tbBuscarVuelo.Text));
                if (b != null)
                {
                    Console.WriteLine(b.DatosBillete());
                    MessageBox.Show("Tus billetes son" + b.DatosBillete(), "Vuelo Encontrado");
                }
                else
                {
                    MessageBox.Show("No hay billetes", "Error");
                }
            }
            else
            {
                MessageBox.Show("No hay billetes", "Error");
            }
        }

        private void btHistorico_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Entrada.listBilletes.DameBilletesDni(dniCliente).ToArray().ToString(), "Vuelos");
        }

        private void Menu_cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
