using System;

namespace HolaMundo
{
    class Program
    {
        //********** Métodos con valores de retorno y parámetros  **********

        static void Main(string[] args)
        {
            Console.WriteLine(Dividir(25, 13));
            Console.Read();
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiplica(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
