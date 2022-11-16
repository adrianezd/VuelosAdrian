using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelosAdrian.Modelo
{
    public class Billetes
    {
        private List<Billete> lista_billetes;
        public Billetes()
        {
            lista_billetes = new List<Billete>();
        }

        public Billetes(List<Billete> lista_billetes)
        {
            this.lista_billetes = lista_billetes;
        }

        public Billete Buscar_id(int id)
        {
            return new Billete();
        }
        public bool Anadir_billete(Billete b)
        {
            lista_billetes.Add(b);
            return true;
        }
        public Billete Buscar_dni(string dni)
        {
            return new Billete();
        }
        public string Mostrar_dni(string dni)
        {
            return "";
        }

    }
}
