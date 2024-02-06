using System;

namespace RegistroIngreso
{
    class Program
    {
        static string nombreDeUsuario;
        static string clave;

        static void Main(string[] args)
        {
            Registro();
            Ingreso();
            Console.Read();
        }

        public static void Registro()
        {
            Console.WriteLine("Por favor ingrese su nombre de usuario");
            nombreDeUsuario = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su clave");
            clave = Console.ReadLine();
            Console.WriteLine("Registro exitoso");
            Console.WriteLine("--------------------");
        }

        public static void Ingreso()
        {
            Console.WriteLine("Por favor ingrese su nombre de usuario");
            if(nombreDeUsuario == Console.ReadLine())
            {
                Console.WriteLine("Por favor ingrese su clave");
                if (clave == Console.ReadLine())
                {
                    Console.WriteLine("Ingreso exitoso!");
                }
                else
                {
                    Console.WriteLine("Clave incorrecta, por favor reinicie el programa");
                }

            }
            else
            {
                Console.WriteLine("Nombre de usuario incorrecto, por favor reinicie el programa");
            }
        }
    }
}
