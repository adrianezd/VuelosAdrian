using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelosAdrian
{
    public class Billete
    {
        private int id;
        private Persona p;
        private Vuelo vueloIda;
        private Vuelo vueloVuelta;
        private bool ida_vuelta;
        private static int cont=0;

        public int Id { get => id; set => id = value; }
        public Persona P { get => p; set => p = value; }
        public Vuelo VueloIda { get => vueloIda; set => vueloIda = value; }
        public Vuelo VueloVuelta { get => vueloVuelta; set => vueloVuelta = value; }
        public bool Ida_vuelta { get => ida_vuelta; set => ida_vuelta = value; }
        public static int Cont { get => cont; set => cont = value; }

        public Billete()
        {
            id= cont++;
        }
        public Billete(Persona p, Vuelo vueloIda, Vuelo vueloVuelta)
        {
            this.id = cont++;
            this.p = p;
            this.vueloIda = vueloIda;
            this.vueloVuelta = vueloVuelta;
        }

        public Billete(Persona p, Vuelo vueloIda)
        {
            this.id = cont++;
            this.p = p;
            this.vueloIda = vueloIda;
        }

        public Billete(Vuelo vueloIda, Vuelo vueloVuelta)
        {
            this.vueloIda = vueloIda;
            this.vueloVuelta = vueloVuelta;
        }

        public Billete(int id,Persona p, Vuelo vueloIda, Vuelo vueloVuelta, bool ida_vuelta)
        {
            this.id = id;
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

        public string DatosBillete()
        {
            if (vueloIda != null && vueloVuelta != null)
            {
                return vueloIda.Destino + vueloIda.Fecha +  vueloIda.Origen + vueloVuelta.Destino + vueloVuelta.Fecha + vueloVuelta.Destino + this.id;
            }
            else if(vueloVuelta == null)
            {
                return vueloIda.Destino + vueloIda.Fecha + vueloIda.Origen + this.id;
            }
            else
            {
                return vueloVuelta.Destino + vueloVuelta.Fecha + vueloVuelta.Destino + this.id;
            }
        }
    }
}
