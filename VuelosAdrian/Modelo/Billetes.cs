using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace VuelosAdrian
{
    public class Billetes
    {
        public static Dictionary<int,Billete> lista_billetes;
        public Billetes()
        {
            lista_billetes = new Dictionary<int,Billete>();
        }

        public Billetes(Dictionary<int,Billete> lb)
        {
            lista_billetes = lb;
        }

        public Billete Buscar_id(int id)
        {
            foreach (Billete b in lista_billetes.Values)
            {
                if (b.Id == id) { return b; }
            }
            return null;
        }
        public Billete Buscar_id2(string dni)
        {
            if (dni != "")
            {
                return lista_billetes.Values.FirstOrDefault(billete => billete.P.Dni == dni);
            }
            return null;
        }
        public List<Billete> DameBilletesDni(string dni)
        {
            if (dni != "")
            {
                var a = lista_billetes.Values.ToList();
                return a.FindAll(billete => billete.P.Dni == dni);
            }
            return null;
        }
        public List<Billete> DameBilletesDni2(string dni)
        {
            List<Billete> billetesEncontrados = new List<Billete>();
            foreach(Billete b in lista_billetes.Values)
            {
                if(b.P.Dni == dni)
                {
                    billetesEncontrados.Add(b);
                }
            }
            return billetesEncontrados;
        }
        public bool Anadir_billete(Billete b)
        {
            lista_billetes.Add(b.Id,b);
            return true;
        }

        public int Num_vuelos_p(string dni)
        {
            var a = lista_billetes.Values.ToList();
            return a.FindAll(billete => billete.P.Dni == dni).Count;
        }

        public bool Eliminar_billete(string dni)
        {
            var a = lista_billetes.Values.ToList();
            Billete b = Buscar_id2(dni);
            a.RemoveAll(Billete => Billete.P.Dni == dni);
            return true;
        }

    }
}
