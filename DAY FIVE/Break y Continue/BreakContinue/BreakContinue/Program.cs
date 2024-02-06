using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 0; contador < 10; contador++)
            {
              
                if (contador %2 == 0)
                { Console.WriteLine("El próximo es impar");
                    continue;
                }
                Console.WriteLine(contador);
            }
            Console.Read();
        }
    }
}
