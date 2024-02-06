using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeAlgo();
            EscribeAlgoEspecifico("Soy un argumento y me llamaron desde un método");
            Console.Read();
        }

        // NivelDeAcceso - (static) - TipoDeRetorno - NombreDelMétodo (Parámetro1, Parámetro2)
        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo nací en un método");
        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
        }

    }
}
