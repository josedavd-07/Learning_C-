using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversión Explícita
            double miDouble = 13.37;
            int miInt;

            miInt = (int)miDouble;

            // Conversión Implícita

            int num = 123456;
            long numg = num;

            float miFloat = 13.37F;
            double miNuevoDouble = miFloat;

            string miFloatString = miFloat.ToString();

            bool elSolBrilla = true;
            string miBoolString = elSolBrilla.ToString();

            //Conversión de Tipo
            string miString = miDouble.ToString();

            Console.WriteLine(miBoolString);
            Console.WriteLine(miString);
            Console.WriteLine(miFloatString);
            Console.WriteLine(miNuevoDouble);
            Console.WriteLine(numg);
            Console.WriteLine(miInt);
            Console.WriteLine(miDouble);
            Console.Read();
        }
    }
}
