using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelosAdrian
{
    public class Vuelo
    {
        private String origen;
        private String destino;
        private DateTime fecha;

        public Vuelo()
        {
            this.origen = "";
            this.destino = "";
            this.fecha = DateTime.Now;
        }

        public Vuelo(string origen, string destino, DateTime fecha)
        {
            this.origen = origen;
            this.destino = destino;
            this.fecha = fecha;
        }

        public string Origen { get => origen; set => origen = value; }
        public string Destino { get => destino; set => destino = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        public void Mostrar()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return this.origen + this.destino + this.fecha;
        }
    }
}
