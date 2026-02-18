using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace _2condicionesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nb = "";
            float sueldo = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nb = Console.ReadLine();
            Console.WriteLine("Ingerese el sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());
            if (sueldo >= 3000)
            {
                Console.WriteLine($"El usuerio {nb} debe abonar impuesto");

             
            }*/

            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad= Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
           
        
        
        
        
        }
    }
}
