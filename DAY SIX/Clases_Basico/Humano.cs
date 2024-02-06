using System;

namespace Clases_Basico
{
    class Humano
    {
        //Vamos a crear un Miembro Variable
        public string primerNombre;
        public string Apellido;

        //Crearemos un nuevo Miembro Metodo
        public void presentarme()
        {
            Console.WriteLine("Hola, soy {0} {1}", primerNombre, Apellido);
        }
    }
}
