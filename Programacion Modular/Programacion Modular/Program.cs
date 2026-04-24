using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BorrarPantalla();
            Console.WriteLine($"Edad: {CalculaEdad()}");
        }
        static void BorrarPantalla()
        {
            Console.Clear();
        }
        static void Saludo()
        {
            string nombre = "Paloma";
            Console.WriteLine($"Bienvenid@ {nombre}");
        }
        static int CalculaEdad()
        {
            int añoact = 2026;
            int añonac = 2001;
            int edad = añoact - añonac;
            return edad;

        }
        static int CalcularEdad(int añoactual,int añonacimiento)
        {
            return añoactual - añonacimiento;
        }

    }
}
