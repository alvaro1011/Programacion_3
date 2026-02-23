using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine();

            Console.Write("Ingrese el nombre de la empresa: ");
            string empresa = Console.ReadLine();

            string correo = (nombre + "." + apellido + "@" + empresa + ".com").ToLower();

            Console.WriteLine("Su correo generado es: " + correo);

            Console.ReadLine();
            Console.Clear();
        }
    }
}
