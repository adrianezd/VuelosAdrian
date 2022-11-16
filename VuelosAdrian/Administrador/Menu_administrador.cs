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
    public partial class Menu_administrador : Form
    {
        public Menu_administrador()
        {
            InitializeComponent();
        }

        private void btAddCliente_Click(object sender, EventArgs e)
        {
            Anadir_Clientes a1 = new Anadir_Clientes();
            a1.ShowDialog();
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrearAeropuertos_Click(object sender, EventArgs e)
        {

        }
    }
}
