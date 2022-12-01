using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VuelosAdrian.Administrador
{
    public partial class PanelBilletes : Form
    {
        public PanelBilletes()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PanelBilletes_Load(object sender, EventArgs e)
        {
            List<Billete> lista = Billetes.lista_billetes.Values.ToList();
            listBox1.Items.AddRange(lista.ToArray());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar algun billete", "ERROR!", MessageBoxButtons.OK);
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
