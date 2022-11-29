﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VuelosAdrian.Administrador;

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
            PanelAeropuerto m1 = new PanelAeropuerto();
            m1.ShowDialog();
            this.Close();
        }

        private void btVerBilletes_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            foreach (Persona p in Personas.lista_personas)
            {
                Debug.WriteLine(p.Dni);
                Console.WriteLine("el dni" + Entrada.listBilletes.Num_vuelos_p(p.Dni));
                Series s = chart1.Series.Add(p.Nombre);
                s.Points.Add(Entrada.listBilletes.Num_vuelos_p(p.Dni));
                s.Label = p.Nombre;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFichero.Text = openFileDialog1.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFichero.Text = openFileDialog1.FileName;
            }
        }

        private void btModificarBillete_Click(object sender, EventArgs e)
        {
            PanelBilletes m1 = new PanelBilletes();
            m1.ShowDialog();
            this.Close();
        }
    }
}
