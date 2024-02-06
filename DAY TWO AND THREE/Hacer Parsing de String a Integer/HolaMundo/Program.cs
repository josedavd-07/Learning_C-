//using System;

//namespace HolaMundo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Haciendo un Parsing de string a int pero sew puede hacer 
//            // de un string a cualquier tipo de dato numerico 
//            string miString = "15a";
//            string miSegundoString = "10";

//            string resultado = miString + miSegundoString;

//            int num1 = Int32.Parse(miString);
//            int num2 = Int32.Parse(miSegundoString);

//            int resultado2 = num1 + num2;
//            Console.WriteLine(resultado2);

//            //*********************************
//            Console.Write("\n");
//            Console.Write("-------------------------------------------\n");
//            string nombre = "Jose David";
//            string Apellido = "Carranza Angarita";
//            string nombreCompleto = string.Concat("", nombre, Apellido, "");
//            Console.WriteLine(nombre.Substring(1));//salida ose
//            Console.WriteLine(nombre.ToLower());//salida jose david
//            Console.WriteLine(nombre.ToUpper());//salida JOSE DAVID
//            Console.WriteLine(nombreCompleto);//salida Jose David Carranza Angarita
//            Console.Read();




//        }
//    }
//}
  

using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Haciendo un Parsing de string a int pero se puede hacer 
            // de un string a cualquier tipo de dato numerico 
            string miString = "15";  // Cambiado a un número entero válido
            string miSegundoString = "10";

            string resultado = miString + miSegundoString;

            int num1 = Int32.Parse(miString);
            int num2 = Int32.Parse(miSegundoString);

            int resultado2 = num1 + num2;
            Console.WriteLine(resultado2);

            //*********************************
            //Codigo de la demostracion de las funciondes de string con algunos de sus metodos
            Console.Write("\n");
            Console.Write("-------------------------------------------\n");
            string nombre = "Jose";
            string Apellido = "Carranza";
            string nombreCompleto = string.Concat("",nombre,Apellido,"");
            Console.WriteLine(nombre.Substring(1));// Salida ose
            Console.WriteLine(nombre.ToLower());// Salida jose
            Console.WriteLine(nombre.ToUpper());// Salida JOSE
            Console.WriteLine(nombreCompleto.Trim());// Salida JoseCarranza
            Console.WriteLine(nombre.IndexOf('e'));// Salida 1 
            Console.WriteLine(string.IsNullOrWhiteSpace(nombre));// Salida false
            Console.Read();
        }
    }
}
