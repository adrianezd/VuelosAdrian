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
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void btLoguear_Click(object sender, EventArgs e)
        {
            if(tbNombre.Text=="admin" && tbContrasena.Text == "1234")
            {
                Menu_administrador a1 = new Menu_administrador();
                a1.Show();
                this.Close();
            }
            else if(tbNombre.Text=="pepe" && tbContrasena.Text == "1234")
            {
                Menu_cliente c1 = new Menu_cliente();
                c1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Introduce de nuevo las credenciales, inutil");
            }
        }

        private void tbContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
