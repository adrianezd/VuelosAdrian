using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VuelosAdrian
{
    public class Aeropuerto
    {
        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }

        public Aeropuerto(string nombre)
        {
            Nombre = nombre;
        }
        public override string ToString()
        {
            return nombre;
        }
    }

}
