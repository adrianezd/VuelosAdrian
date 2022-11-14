using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Persona
    {
        private string nombre;
        private string apellidos;
        private string direccion;
        private string dni;

        public Persona()
        {
            this.nombre = "";
            this.apellidos = "";
            this.direccion = "";
            this.dni = "";

        }
        public Persona(string nombre, string apellidos, string direccion, string dni)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.dni = dni;
        }

        public void Mostrar()
        {
            Console.WriteLine(this.nombre + " - " + this.apellidos + " - " + this.direccion + " - " + this.dni);
        }
    }


}
