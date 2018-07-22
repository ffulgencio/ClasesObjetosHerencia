using System;
using System.Collections.Generic;
using MarioBros;

namespace Clases
{
      class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.nombre = "Juan";
            p.apellido = "Perez";
            p.edad = 23;
            //p.MostrarDatos();

            Empleado e1 = new Empleado();
            

            Persona p2 = new Persona("Maria", "De Belen", 86);
            p2.MostrarDatos();
            Console.WriteLine(Operaciones.Suma(2,5));
            

            Empleado e = new Empleado();

            Jugador Mario = new Jugador();
            Mario.Mover();


        }

        public void Mirar()
        {

        }

        public static void Saludar()
        {
            Console.WriteLine("Hola");
        }
    }

    


    






}
