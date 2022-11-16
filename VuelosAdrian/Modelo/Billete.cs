using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Billete
    {
        private Persona p;
        private Vuelo vueloIda;
        private Vuelo vueloVuelta;
        private bool ida_vuelta;

        public Billete()
        {

        }
        public Billete(Persona p, Vuelo vueloIda, Vuelo vueloVuelta)
        {
            this.p = p;
            this.vueloIda = vueloIda;
            this.vueloVuelta = vueloVuelta;
        }

        public Billete(Persona p, Vuelo vueloIda)
        {
            this.p = p;
            this.vueloIda = vueloIda;
        }

        public Billete(Vuelo vueloIda, Vuelo vueloVuelta)
        {
            this.vueloIda = vueloIda;
            this.vueloVuelta = vueloVuelta;
        }

        public Billete(Persona p, Vuelo vueloIda, Vuelo vueloVuelta, bool ida_vuelta)
        {
            this.p = p;
            this.vueloIda = vueloIda;
            this.vueloVuelta = vueloVuelta;
            this.ida_vuelta = ida_vuelta;
        }

        public void Mostrar()
        {
            p.Mostrar(); vueloVuelta.Mostrar(); vueloIda.Mostrar();
        }
        public override string ToString()
        {
            if (ida_vuelta)
            {
                return p.ToString() + "\n" + vueloIda;
            }
            else
            {
                return "Compra realizada con éxito para: " + Environment.NewLine + p.ToString() + Environment.NewLine + vueloIda.ToString() + Environment.NewLine + vueloVuelta.ToString();
            }

        }
    }
}
