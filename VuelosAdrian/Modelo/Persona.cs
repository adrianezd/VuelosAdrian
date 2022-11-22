using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuelosAdrian
{
    public class Persona
    {
        private string nombre;
        private string apellidos;
        private string direccion;
        private string dni;
        private string contrasena;

        public Persona()
        {
            this.nombre = "";
            this.apellidos = "";
            this.direccion = "";
            this.dni = "";
            this.contrasena = "";

        }
        public Persona(string nombre, string apellidos, string direccion, string dni,int tamano)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.dni = dni;
            this.contrasena = generador_pass(tamano);
        }

        public Persona(string nombre, string apellidos, string direccion, string dni, string contrasena)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.dni = dni;
            this.contrasena = contrasena;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }

        public void Mostrar()
        {
            Console.WriteLine(this.nombre + " - " + this.apellidos + " - " + this.direccion + " - " + this.dni + " - " + this.contrasena);
        }
        public override String ToString()
        {
            return this.nombre + " - " + this.apellidos + " - " + this.direccion + " - " + this.dni + " - " + this.contrasena;
        }

        public string generador_pass(int tamano)
        {
            var chars ="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[tamano];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            return (new String(stringChars));
        }



    }


}
