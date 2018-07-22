using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    partial class Persona 
    {
        public Persona()
        {
            Console.WriteLine("Se ha instanciado un objeto");
        }

        public Persona(string name, string lastname, int age)
        {
            this.nombre = name;
            this.apellido = lastname;
            this.edad = age;
        }



        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: {0}, Apellido: {1}, Edad: {2}", nombre, apellido, edad);
        }
    }
}
