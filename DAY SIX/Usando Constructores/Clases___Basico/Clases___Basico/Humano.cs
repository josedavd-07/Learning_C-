using System;

namespace Clases___Basico
{
    class Humano
    {
        // Miembro Variable
        private string primerNombre;
        private string apellido;
        private string colorOjos;
        private int edad;
        private string nacionalidad;


        //Miembro constructor
        public Humano(string primerNombre, string apellido, string colorOjos, int edad , string nacionalidad)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
        }

        //Miembro Método
        public void presentarme()
        {
            if (edad == 1)
            Console.WriteLine("Hola, soy {0} {1} y tengo {2} año de edad. Mi color de ojos es {3} y soy de {4}"
                , primerNombre, apellido, edad, colorOjos, nacionalidad);
            else
                Console.WriteLine("\nHola, soy {0} {1} y tengo {2} años de edad. Mi color de ojos es {3} y soy de {4}"
                , primerNombre, apellido, edad, colorOjos , nacionalidad);
        }

        
    }
}
