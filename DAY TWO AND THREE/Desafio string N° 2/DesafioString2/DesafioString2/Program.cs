using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioString2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Por favor ingrese un texto: ");
            //string ingreso = Console.ReadLine();
            //Console.WriteLine("Ingrese el caracter que quiere buscar en el texto: ");
            //char ingresoBuscado = Console.ReadLine()[0];
            //int buscarIndice = ingreso.IndexOf(ingresoBuscado);
            //Console.WriteLine("El índice del caracter {0} en el texto es {1}", ingresoBuscado, buscarIndice);
            //Console.ReadKey();

            Console.WriteLine("Por favor ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su apellido: ");
            string apellido = Console.ReadLine();
            string nombrecompleto = String.Concat(nombre, " ", apellido);
            Console.WriteLine("El nombre completo es {0}", nombrecompleto);
            Console.ReadKey();

        }
    }
}
