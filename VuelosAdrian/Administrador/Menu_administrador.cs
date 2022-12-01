using System;
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
            ColoresRestaurados();
            btAddCliente.BackColor = Color.LightGreen;
            Anadir_Clientes a1 = new Anadir_Clientes();
            a1.ShowDialog();
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            ColoresRestaurados();
            btSalir.BackColor = Color.LightGreen;
            this.Close();
        }

        private void btCrearAeropuertos_Click(object sender, EventArgs e)
        {
            ColoresRestaurados();
            btCrearAeropuertos.BackColor = Color.LightGreen;
            PanelAeropuerto m1 = new PanelAeropuerto();
            m1.ShowDialog();
            this.Close();
        }

        private void btVerBilletes_Click(object sender, EventArgs e)
        {
            ColoresRestaurados();
            btVerBilletes.BackColor = Color.LightGreen;
            chart1.Visible = true;
            chart1.Series.Clear();
            foreach (Persona p in Personas.lista_personas)
            {
                Debug.WriteLine(p.Dni);
                Console.WriteLine("el dni" + Entrada.listBilletes.Num_vuelos_p(p.Dni));
                Series s = chart1.Series.Add(p.Nombre);
                s.Points.Add(Entrada.listBilletes.Num_vuelos_p(p.Dni));
                s.ChartType = SeriesChartType.Line;
                s.Label = p.Nombre;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ColoresRestaurados();
            btnCargar.BackColor = Color.LightGreen;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFichero.Text = openFileDialog1.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ColoresRestaurados();
            btnGuardar.BackColor = Color.LightGreen;
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

        private void ColoresRestaurados()
        {
            btVerBilletes.BackColor = SystemColors.Window;
            btnCargar.BackColor = SystemColors.Window;
            btModificarBillete.BackColor = SystemColors.Window;
            btAddCliente.BackColor = SystemColors.Window;
            btCrearAeropuertos.BackColor = SystemColors.Window;
            btnGuardar.BackColor = SystemColors.Window;
        }
    }
}
