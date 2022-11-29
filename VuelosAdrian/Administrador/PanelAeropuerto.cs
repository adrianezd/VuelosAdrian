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
    public partial class PanelAeropuerto : Form
    {
        public PanelAeropuerto()
        {
            InitializeComponent();
        }

        private void PanelAeropuerto_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Aeropuertos.Lista_aeropuertos.ToArray());
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbAeropuerto.Text))
            {
                MessageBox.Show("Debes agregar algun nombre de aeropuerto", "ERROR!", MessageBoxButtons.OK);
                tbAeropuerto.Focus();
                tbAeropuerto.BackColor = Color.IndianRed;
            }
            else
            {
                listBox1.Items.Add(tbAeropuerto.Text);
                RespuestaCorrecta();
            }
        }

        private void RespuestaCorrecta()
        {
            tbAeropuerto.BackColor = SystemColors.Window;
            tbAeropuerto.Text = String.Empty;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar algun aeropuerto", "ERROR!", MessageBoxButtons.OK);
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

    }
}
