using System;

namespace Clases___Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Usando Múltiples Constructores";
            Humano natalio = new Humano("Natalio");
            Humano juana = new Humano("Juana", "Garay", "verde");
            Humano milena = new Humano("Milena", "Millera");
            Humano Antonio = new Humano("Antonio", "Camilo", "Azul", 7);

            natalio.presentarme();
            juana.presentarme();
            milena.presentarme();
            Antonio.presentarme();


            Console.Read();
        }
    }
}
      