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
    public partial class Anadir_Clientes : Form
    {

        public static int index = -2;
        BindingSource bindingSource = new BindingSource();
        public Anadir_Clientes()
        {
            InitializeComponent();
        }

        private void btAnadir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNombre.Text) || String.IsNullOrEmpty(tbApellidos.Text) || String.IsNullOrEmpty(tbDireccion.Text) || String.IsNullOrEmpty(tbApellidos.Text) || (String.IsNullOrEmpty(tbContra.Text) && (checkBox1.Checked == false)))
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
                if (String.IsNullOrEmpty(tbContra.Text)&&(checkBox1.Checked == false))
                {
                    MessageBox.Show("Completa la contraseña", "Error");
                    tbContra.BackColor = Color.Red;
                }
            }
            else
            {
                tbNombre.BackColor = SystemColors.Window; tbApellidos.BackColor = SystemColors.Window; tbDireccion.BackColor = SystemColors.Window; tbDni.BackColor = SystemColors.Window;tbContra.BackColor = SystemColors.Window;
                if (checkBox1.Checked)
                {
                    Persona p = new Persona(tbNombre.Text, tbApellidos.Text, tbDireccion.Text, tbDni.Text, Convert.ToInt32(Math.Round(numericUpDown1.Value, 0)));
                    bindingSource.Add(p);
                    Personas.lista_personas.Add(p);
                }
                else
                {
                    Persona p = new Persona(tbNombre.Text, tbApellidos.Text, tbDireccion.Text, tbDni.Text, tbContra.Text);
                    bindingSource.Add(p);
                    Personas.lista_personas.Add(p);
                }

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
                DialogResult resultado = MessageBox.Show("¿Este cliente tiene billetes asociados, desea eliminarlos?", "Alert");
                if (resultado == DialogResult.OK)
                {
                    bindingSource.RemoveCurrent();
                    MessageBox.Show("Borrado con éxito");
                }
                else
                {
                    MessageBox.Show("De acuerdo, siga en la app");
                }

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void Anadir_Clientes_Load(object sender, EventArgs e)
        {
            foreach(Persona p in Personas.lista_personas)
            {
                bindingSource.Add(p);

            }
            dataGridView1.DataSource = bindingSource;
            this.dataGridView1.Columns["dni"].Visible = false;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                numericUpDown1.Minimum = 5;
                if (checkBox1.Checked)
                {
                    numericUpDown1.Visible = true;
                    tbContra.Visible = false;
                    lbContra.Visible = false;
                }
                else
                {
                    tbContra.Visible = true;
                    lbContra.Visible = true;
                    checkBox1.Checked = false;
                    numericUpDown1.Visible = false;
                }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

