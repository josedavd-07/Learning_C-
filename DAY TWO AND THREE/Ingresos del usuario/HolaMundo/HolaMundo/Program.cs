using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calcular());
            Console.Read();
        }

        public static int Calcular()
        {
            Console.WriteLine("Por favor, ingresa un número");
            string numero1Input = Console.ReadLine();
            Console.WriteLine("Por favor, ingresa otro número");
            string numero2Input = Console.ReadLine();

            int num1 = int.Parse(numero1Input);
            int num2 = int.Parse(numero2Input);

            int resultado = num1 + num2;
            return resultado;
        }
    }
}
