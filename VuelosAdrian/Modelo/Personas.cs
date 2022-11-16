using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelosAdrian.Modelo
{
    public class Personas
    {
        private List<Persona> lista_personas;

        public Personas()
        {
            this.lista_personas = new List<Persona>();
        }

        public Personas(List<Persona> lista_personas)
        {
            this.lista_personas = lista_personas;
        }

        public bool Dni_existe(string dni)
        {
            return true;
        }
        public bool Anadir_persona(Persona p)
        {
            lista_personas.Add(p);
            return true;
        }
    }
}
