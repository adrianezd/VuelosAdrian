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
    public partial class Anadir_Clientes : Form
    {
        public static int index = -2;
        public Anadir_Clientes()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNombre.Text) || String.IsNullOrEmpty(tbApellidos.Text) || String.IsNullOrEmpty(tbDireccion.Text) || String.IsNullOrEmpty(tbApellidos.Text))
            {
                if (String.IsNullOrEmpty(tbNombre.Text))
                {
                    MessageBox.Show("Completa el nombre", "Error");
                    tbNombre.BackColor = Color.Red;
                }
                if (String.IsNullOrEmpty(tbApellidos.Text))
                {
                    MessageBox.Show("Completa los apellidos", "Error");
                    tbApellidos.BackColor = Color.Red;
                }
                if (String.IsNullOrEmpty(tbDireccion.Text))
                {
                    MessageBox.Show("Completa la direccion", "Error");
                    tbDireccion.BackColor = Color.Red;
                }
                if (String.IsNullOrEmpty(tbDni.Text))
                {
                    MessageBox.Show("Completa el dni", "Error");
                    tbDni.BackColor = Color.Red;
                }
            }
            else
            {
                tbNombre.BackColor = SystemColors.Window; tbApellidos.BackColor = SystemColors.Window; tbDireccion.BackColor = SystemColors.Window; tbDni.BackColor = SystemColors.Window;
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = tbNombre.Text;
                dataGridView1.Rows[n].Cells[1].Value = tbApellidos.Text;
                dataGridView1.Rows[n].Cells[2].Value = tbDireccion.Text;
                dataGridView1.Rows[n].Cells[3].Value = tbDni.Text;
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if(index == -2 || index == -1)
            {
                MessageBox.Show("A ver, inutil, selecciona alguno");
            }
            else
            {
                dataGridView1.Rows.RemoveAt(index);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
