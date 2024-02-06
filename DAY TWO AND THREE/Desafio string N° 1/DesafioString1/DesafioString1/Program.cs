using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatosString
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************************
            //Prueba de los formatos en string con algunos de sus metodos.
            string miNombre;
            Console.WriteLine("Por favor ingrese su nombre: ");
            miNombre = Console.ReadLine();
            string minombreMayuscula = String.Format("En mayúsculas es {0}", miNombre.ToUpper());
            string miNombreMinuscula = String.Format("En minúsculas sería {0}", miNombre.ToLower());
            string miNombreSinEspacios = String.Format("Sin espacios sería {0}", miNombre.Trim());
            string miNombreSubString = String.Format("Valor del substring es {0}", miNombre.Substring(0, 5));
            Console.WriteLine(minombreMayuscula);
            Console.WriteLine(miNombreMinuscula);
            Console.WriteLine(miNombreSinEspacios);
            Console.WriteLine(miNombreSubString);
            Console.ReadKey();
        }
    }
}
