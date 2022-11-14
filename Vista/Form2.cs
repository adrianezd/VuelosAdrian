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
    public partial class Form2 : Form
    {
        public string datos = "";
        public Form2(string origen,string destino, DateTime fecha, DateTime fechavuelta,bool soloida)
        {
            InitializeComponent();
            tbOrigen.Text = origen;
            tbDestino.Text = destino;
            tbIda.Text = fecha.ToString();
            if (soloida == true)
            {
                tbVuelta.Visible = false;
                lbFechaVuelta.Visible = false;
            }
            else
            {
                tbVuelta.Text = fechavuelta.ToString();
            }
            tbNombre.Text = ""; tbApellidos.Text =""; tbDireccion.Text = "";tbDni.Text = "";
            tbOrigen.Enabled = false;tbDestino.Enabled = false;tbIda.Enabled= false;tbVuelta.Enabled = false;
        }

        private void btComprarBillete_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbNombre.Text) || String.IsNullOrEmpty(tbApellidos.Text) || String.IsNullOrEmpty(tbDireccion.Text) || String.IsNullOrEmpty(tbApellidos.Text))
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
            else
            {
                tbNombre.BackColor = SystemColors.Window;tbApellidos.BackColor = SystemColors.Window;tbDireccion.BackColor = SystemColors.Window;tbDni.BackColor = SystemColors.Window;
                datos = DameDatos();
                this.Close();
            }

        }

        public string DameDatos()
        {
            return "Compra realizada con éxito para: " + Environment.NewLine + "Nombre: " + tbNombre.Text + Environment.NewLine 
                + "Apellidos: " + tbApellidos.Text + Environment.NewLine  
                + "Direccion: " + tbDireccion.Text + Environment.NewLine
                + "Dni: " + tbDni.Text + Environment.NewLine;
        }

        private void IluminarCampo(Object campo)
        {

        }
    }
}
