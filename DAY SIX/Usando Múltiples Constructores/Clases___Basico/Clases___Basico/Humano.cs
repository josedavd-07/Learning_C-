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

        //constructor no parametrizado o por defecto
        public Humano()
        {
            Console.WriteLine("Constructor llamado. Objeto creado");
        }


        //Miembro constructor parametrizado
        public Humano(string primerNombre, string apellido, string colorOjos, int edad)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
            this.edad = edad;
        }

        public Humano(string primerNombre, string apellido, string colorOjos)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
            this.colorOjos = colorOjos;
        }

        public Humano(string primerNombre, string apellido)
        {
            this.primerNombre = primerNombre;
            this.apellido = apellido;
        }

        public Humano(string primerNombre)
        {
            this.primerNombre = primerNombre;
        }
        //Miembro Método
        public void presentarme()
        {
            if (edad != 0 && primerNombre != null && apellido != null && colorOjos != null)
            Console.WriteLine("Hola, soy {0} {1} y tengo {2} años de edad. Mi color de ojos es {3}"
                , primerNombre, apellido, edad, colorOjos);
            else if (primerNombre != null && apellido != null && colorOjos != null)
                Console.WriteLine("Hola, soy {0} {1}. Mi color de ojos es {2}"
                , primerNombre, apellido, colorOjos);
            else if (primerNombre != null && apellido != null)
                Console.WriteLine("Hola, soy {0} {1}"
                , primerNombre, apellido);
            else if (primerNombre != null)
                Console.WriteLine("Hola, soy {0}"
                , primerNombre);
        }
    }
}
