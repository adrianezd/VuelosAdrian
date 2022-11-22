using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VuelosAdrian
{
    public class Personas
    {
        public static List<Persona> lista_personas;

        public Personas()
        {
            lista_personas = new List<Persona>();
        }

        public Personas(List<Persona> lista_personas)
        {
            lista_personas = lista_personas;
        }

        public bool Dni_existe(string dni)
        {
            return true;
        }
        public void Anadir_persona(Persona p)
        {
            lista_personas.Add(p);
        }

        public Persona DamePersona(string dni)
        {
            foreach (Persona p in lista_personas)
            {
                if (p.Dni == dni)
                {
                    return p;
                }
            }
            return null;
        }

        public void LeerPersona()
        {
            foreach (Persona p in lista_personas)
            {
                Console.WriteLine(p);
            }
        }

        public bool Eliminar_persona(Persona p)
        {
            return lista_personas.Remove(p);
        }


    }
}
