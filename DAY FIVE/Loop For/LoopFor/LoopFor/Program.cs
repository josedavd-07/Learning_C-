using System;

namespace LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int contador = 1; contador < 20; contador+=2)
            {
                Console.WriteLine(contador + " es impar");
            }
            Console.Read();
        }
    }
}
