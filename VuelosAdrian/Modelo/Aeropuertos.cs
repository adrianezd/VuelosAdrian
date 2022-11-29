using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelosAdrian
{
    public class Aeropuertos
    {
        private static List<Aeropuerto> lista_aeropuertos;

        public Aeropuertos()
        {
            lista_aeropuertos = new List<Aeropuerto>();
        }

        public Aeropuertos(List<Aeropuerto> todosAeropuertos)
        {
            lista_aeropuertos = todosAeropuertos;
        }

        public static List<Aeropuerto> Lista_aeropuertos { get => lista_aeropuertos; set => lista_aeropuertos = value; }

        public void Anadir_Aeropuerto(Aeropuerto terminal) 
        {
            lista_aeropuertos.Add(terminal);
        }
        public void Borrar_Aeropuerto(Aeropuerto terminal)
        {
            lista_aeropuertos.Remove(terminal);
        }

    }

}
