using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string amigo1 = "Pablo";
            string amigo2 = "Daniel";
            string amigo3 = "Lucas";

            SaludarAmigo(amigo1, amigo2, amigo3);
            Console.Read();
        }

        public static void SaludarAmigo(string nombreAmigo1, string nombreAmigo2, string nombreAmigo3)
        {
            Console.WriteLine("¡Hola " + nombreAmigo1 + ", que tengas un buen día!");
            Console.WriteLine("¡Hola " + nombreAmigo2 + ", que tengas un buen día!");
            Console.WriteLine("¡Hola " + nombreAmigo3 + ", que tengas un buen día!");
        }

    }
}
