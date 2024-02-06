using System;
using System.Collections.Generic;
using System.Linq;                  //Todas estas son librerias que podemos usar en nuestro programa 
using System.Text;                 // y asi reutilizar codigo ya hecho      
using System.Threading.Tasks;    // Es una buena practica solo dejar las librerias que vas usar para que el programa no se haga pesado y no consuma tanta memoria

namespace holaMundo   //Este es el nombre del proyecto
{
    class Program   //Esta es la clase principal
    {
        static void Main(string[] args)   //Este es el metodo principal
        {
            //Console hace parte de la libreria System
            //WriteLine es un metodo de la clase Console
            //WriteLine es un metodo que imprime en pantalla y hace un salto de linea

            Console.Title = "Hola Mundo C#"; //Este es el titulo que se mostrara en la consola

            Console.WriteLine(">> Hello, World!"); //Este es el mensaje que se mostrara en pantalla
            Console.WriteLine(">> Hola jose recuerda este dia de hoy 24 de novienbre del 2023.");
            Console.WriteLine(">> seras un experto programador , cree en ti siempre y l lograras.");
            Console.WriteLine(">> Hola hoy 17 de enero del 2024 estas por aqui de nuevo mejorando y aprendiendo más cada día.");
            Console.WriteLine(">> Estoy orgullo de ti por todo lo que haz logrado conseguir y hacer en todo este tiempo haz crecido mucho desde la ultima vez sigue asi te quiero mucho.");

            Console.Read();  //Este metodo hace que el programa se detenga hasta que el usuario presione una tecla
            // esta es otra manera de hacerlo de esta manera no se detiene el programa gracias a la libreria System.Threading hasta que 
            //el usuario presione una tecla
            //Console.ReadKey(); //Este metodo hace que el programa se detenga hasta que el usuario presione una tecla
        }
    }
}
