using System;

namespace Clases_Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esto tambien funciona solo qyue lo comente para colocar el codigo de abajo

            ////Crea un objeto desde mi clase
            //// una instancia de la clase Humano
            //Humano Juan = new Humano();
            ////Accediendoa una variable publica externa
            //Juan.primerNombre = "Juan";
            ////Aca estamos llamando a un metodo de la clase
            //Juan.presentarme();

            //Humano Pedro = new Humano();
            //Pedro.primerNombre = "Julio";
            //Pedro.presentarme();


            Humano laura = new Humano();
            Humano carlos = new Humano();
            laura.primerNombre = "Laura";
            carlos.primerNombre = "Carlos";
            laura.Apellido = "Perez";
            carlos.Apellido = "Gonzalez";

            laura.presentarme();
            carlos.presentarme();

            Console.ReadKey();
        }
    }
}
