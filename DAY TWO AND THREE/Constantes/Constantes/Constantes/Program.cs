using System;


namespace Constantes
{
    class Program
    {
        const double PI = 3.14159265359;
        const int semanas = 52, meses = 12;
        const string nacimiento = "07/02/2005";
    

        static void Main(string[] args)
        {
            Console.WriteLine("Mi nacimiento fue el: {0}", nacimiento);
            Console.Read();
        }
    }
}
