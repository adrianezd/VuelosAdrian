using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VuelosAdrian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSelectVuelta_Click(object sender, EventArgs e)
        {
            if (btSelectVuelta.Text == "Seleccionar vuelo de vuelta")
            {
                btSelectVuelta.Text = "No seleccionar vuelta";
                monthCalendarVuelta.Visible = false;
                lbFechaVuelta.Visible = false;
            }
            else
            {
                btSelectVuelta.Text = "Seleccionar vuelo de vuelta";
                monthCalendarVuelta.Visible = true;
                lbFechaVuelta.Visible = true;
            }
        }

        private void cBoxIda_SelectedIndexChanged(object sender, EventArgs e)
        {

            cBoxVuelta.Enabled = true;
            lbVueloOrSelected.Text = "Vuelo de origen seleccionado: " + cBoxIda.SelectedItem.ToString();
            if (cBoxIda.SelectedIndex == -1) // ddl being your dropdown
            {
                lbVueloOrSelected.Text = "Vuelo de origen seleccionado: " + cBoxIda.SelectedItem.ToString();
            }
            cBoxVuelta.Items.RemoveAt(cBoxIda.SelectedIndex);
            //lbVueloOrSelected.Text += cBoxIda.SelectedItem.ToString();


        }

        private void btComprar_Click(object sender, EventArgs e)
        {
            bool soloida = false;
            if (cBoxIda.SelectedIndex == -1 || cBoxVuelta.SelectedIndex == -1 || lbFechaIda.Text == "Con fecha de ida:")
            {
                MessageBox.Show("Falta información del vuelo", "Error en la compra", MessageBoxButtons.OKCancel);
            }
            else
            {
                if (lbFechaVuelta.Visible == false)
                {
                    soloida = true;
                    Form2 form2 = new Form2(cBoxIda.SelectedItem.ToString(), cBoxVuelta.SelectedItem.ToString(), monthCalendarIda.SelectionStart, monthCalendarVuelta.SelectionStart, soloida);
                    form2.ShowDialog();
                    lbCompraHecha.Text = form2.datos;
                    Billete b = form2.billeteDevuelto;
                    b.Mostrar();
                }
                else
                {
                    Form2 form2 = new Form2(cBoxIda.SelectedItem.ToString(), cBoxVuelta.SelectedItem.ToString(), monthCalendarIda.SelectionStart, monthCalendarVuelta.SelectionStart, soloida);
                    form2.ShowDialog();
                    lbCompraHecha.Text = form2.datos;
                    Billete b = form2.billeteDevuelto;
                    b.Mostrar();
                }


            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> ciudades = new List<string>(new string[] { "Madrid", "Barcelona", "Bilbao", "Valencia" });
            foreach (string c in ciudades)
            {
                cBoxIda.Items.Add(c);
                cBoxVuelta.Items.Add(c);
            }
            cBoxVuelta.Enabled = false;
            this.cBoxIda.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cBoxVuelta.DropDownStyle = ComboBoxStyle.DropDownList;
            monthCalendarIda.MinDate = DateTime.Now;


        }

        private void cBoxVuelta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceVuelta = cBoxVuelta.SelectedIndex;
            int indiceIda = cBoxIda.SelectedIndex;
            lbVueloDestSelected.Text = "Vuelo de destino seleccionado: " + cBoxVuelta.SelectedItem.ToString();
            if (cBoxVuelta.SelectedIndex == -1) // ddl being your dropdown
            {
                lbVueloDestSelected.Text = "Vuelo de destino seleccionado: " + cBoxVuelta.SelectedItem.ToString();
            }
            cBoxIda.Items.Remove(cBoxVuelta.SelectedItem);

        }

        private void cBoxVuelta_MouseClick(object sender, MouseEventArgs e)
        {

            List<String> ciudades = new List<string>(new string[] { "Madrid", "Barcelona", "Bilbao", "Valencia" });
            if (cBoxVuelta.SelectedIndex != -1 && cBoxIda.SelectedIndex != -1)
            {
                Object indiceVuelta = cBoxVuelta.SelectedItem;
                Object indiceIda = cBoxIda.SelectedItem;
                cBoxIda.Items.Clear();
                cBoxVuelta.Items.Clear();
                foreach (string c in ciudades)
                {
                    cBoxIda.Items.Add(c);
                    cBoxVuelta.Items.Add(c);
                }
                //cBoxIda.Items.Remove(cBoxVuelta.SelectedItem);
                cBoxVuelta.Items.Remove(cBoxIda.SelectedItem);
                cBoxIda.SelectedItem = indiceIda;
                cBoxVuelta.SelectedItem = indiceVuelta;
            }

            if (cBoxIda.SelectedIndex == -1)
            {
                cBoxVuelta.Enabled = false;
            }
            else
            {
                cBoxVuelta.Enabled = true;
            }
        }

        private void monthCalendarIda_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (String.IsNullOrEmpty(monthCalendarIda.SelectionRange.Start.ToString()))
            {
                lbFechaIda.Text += monthCalendarIda.SelectionRange.Start.ToShortDateString();
            }
            else
            {
                lbFechaIda.Text = "Con fecha de ida:" + monthCalendarIda.SelectionRange.Start.ToString();
            }
            monthCalendarVuelta.MinDate = monthCalendarIda.SelectionRange.Start.AddDays(1.0);
            lbFechaVuelta.Text = "Con fecha de vuelta:" + monthCalendarIda.SelectionRange.Start.ToString();
        }

        private void monthCalendarVuelta_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (String.IsNullOrEmpty(monthCalendarVuelta.SelectionRange.Start.ToString()))
            {
                lbFechaVuelta.Text += monthCalendarVuelta.SelectionRange.Start.ToShortDateString();
            }
            else
            {
                lbFechaVuelta.Text = "Con fecha de vuelta:" + monthCalendarVuelta.SelectionRange.Start.ToString();
            }

        }

        private void cBoxIda_MouseClick(object sender, MouseEventArgs e)
        {
            List<String> ciudades = new List<string>(new string[] { "Madrid", "Barcelona", "Bilbao", "Valencia" });
            if (cBoxVuelta.SelectedIndex != -1 && cBoxIda.SelectedIndex != -1)
            {
                Object indiceVuelta = cBoxVuelta.SelectedItem;
                Object indiceIda = cBoxIda.SelectedItem;
                cBoxIda.Items.Clear();
                cBoxVuelta.Items.Clear();
                foreach (string c in ciudades)
                {
                    cBoxIda.Items.Add(c);
                    cBoxVuelta.Items.Add(c);
                }
                cBoxIda.Items.Remove(cBoxVuelta.SelectedItem);
                cBoxVuelta.Items.Remove(cBoxIda.SelectedItem);
                cBoxIda.SelectedItem = indiceIda;
                cBoxVuelta.SelectedItem = indiceVuelta;
            }
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            Anadir_Clientes ac = new Anadir_Clientes();
            ac.ShowDialog();
        }
    }
}
