 using System;

namespace LoopDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int largoDeTexto = 0;
            string textoCompleto = "";
            do
            {
                Console.WriteLine("Por favor, ingresa el nmbre de un amigo");
                string nombreAmigo = Console.ReadLine();
                int largoActual = nombreAmigo.Length;
                largoDeTexto += largoActual;
                textoCompleto += nombreAmigo;
            } while (largoDeTexto < 20);
            Console.WriteLine("Gracias, eso es todo " + textoCompleto);
            Console.Read();
        }
    }
}
