using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es lo trabajado en la parte de variables  y tipos de datos  de numeros en C# como:
            // int, double, float.

            int num1 = 18;
            int num2 = 7;
            int sum = num1 + num2;
            int num3, num4, num5;

            double d1 = 3.2;
            double d2 = 1.337;
            double sumd = d1 + num2;

            float f1 = 3.5f;

            Console.WriteLine("La suma del double " + d1 + " más el numero entero " + num2
                + " da como resultado " + sumd
                + " porque un numero Entero si cabe en un decimal" +
                " y si puede sumarse pero un decimal no cabe en un entero y son imcompatibles y asi sucesivamente");

            //acaterminamos lo trabajados con variables de numeros y comenzamos con los string

            //--------------------------------------------------------------------------------------------------------------

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n-----------------------------------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            //Esto es lo trabajado en la parte de variables  y tipos de datos  de string en C# como:

            string miNombre = "Jose David Carranza Angarita";
            string mensaje = "Mi nombre es " + miNombre;

            string mensajeMayuscula = mensaje.ToUpper();
            string mensajeMinuscula = mensaje.ToLower();
            Console.WriteLine(mensajeMayuscula);
            Console.WriteLine(mensajeMinuscula);
            Console.ReadLine();

            //--------------------------------------------------------------------------------------------------------------
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n-------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            //Pedimos al usuario que ingrese una cadena de texto que es de tipo string y que luego presione enter parfa hacer la ejecucion del programa como esta planteado en la secuencia del codigo.
            Console.Write("\ningresar un valor te tipo string (Cadena de texto) y presionar Enter: ");
            Console.ForegroundColor = ConsoleColor.Green;
            //Creamos una variable llamada (leerEntrada) que esta es la que pasara a tomoar el valor que Console.ReadLine asumio a la hora de leer la entarada que el usuario digito en la consola.
            string leerEntrada = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            // Ylugo  aca hacemos es mostrar el mensaje que el usuario escribo por medio de indices añadimos el texto almacenado en la variable (leerEntrada) al texto esplicito que se ha puesto antex del texto para explicar el porque del textosiguiente que mostramos.
            Console.WriteLine("\nUsted ha ingresado {0}", leerEntrada);

            //****************
            Console.ForegroundColor = ConsoleColor.White;
            //Le decimos al usuario que ingrese una pulsacion de cualquiera tecla del teclado y que predione enter para salir de esa pregunta y asi validar el dato y comenzar a trbajar con el.
            Console.Write("\n\nIngrese cualquiera tecla y presione Enter para salir: ");
            Console.ForegroundColor = ConsoleColor.Green;
            //Creamos una variable de tipo  intiger con el nombre ( valor Ascci que toma el valor de (Console.Read) que hqce es tomar el valor de esa pulsacion y darnos su valor en Ascii.
            int valorAscii = Console.Read();
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Ahora mostramos el resultado de nuestro programa por medio de indices añadimos el valor Ascii al texto añadido amteriormente y lo mostramos en consola y ahí se acaba la ejecución de nuestro programa codificado en C# yeste ha sido todo por hoy estoy aorgulloso de todo lo que has logrado.
            Console.WriteLine("\nEl valor ASCII de la tecla presionada es de: {0}", valorAscii);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n-----------------------------------------------------------------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
            //******************
        }
    }
}
