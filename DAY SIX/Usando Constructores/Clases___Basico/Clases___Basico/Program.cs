using System;

namespace Clases___Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano luis = new Humano("Luis", "Garay", "Marrón", 42, "colombia");
            Humano ana = new Humano("Ana", "Maina", "Verde", 1, " Brazil");
            Humano carlos = new Humano("Carlos", "Gonzalez", "Azul", 25, "venezuela"); 
            Humano jose = new Humano("Jose", "Angarita", "Verde", 18, "China");
            luis.presentarme();
            ana.presentarme();
            carlos.presentarme();
            jose.presentarme();


            Console.Read();
        }
    }
}
