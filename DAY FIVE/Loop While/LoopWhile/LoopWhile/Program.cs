using System;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string textoIngresado = "";

            while (textoIngresado.Equals(""))
            {
                Console.WriteLine("Por favor presione enter cada vez" +
                    "que un alumno ingrese al bus. Para finalizar ingrese otro valor");
                textoIngresado = Console.ReadLine();
                contador++;
                Console.WriteLine("Alumnos en el bus: {0}", contador);
            }
            Console.Read();
        }
    }
}
