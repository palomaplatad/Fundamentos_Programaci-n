using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15CicloFOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int acumulador = 0;
            for (int i = 0; i <= 5; i++)
            {
                acumulador += i;
            }
            Console.WriteLine (acumulador);*/
            /*int fact = 1;
            int n =  0;
            Console.WriteLine("Ingrese su numero");
            n= int.Parse(Console.ReadLine());
            for (int i = 1; i<= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"El factorial es {fact}");*/
            int rangoinicio = 0;
            int rangofinal = 0;
            Console.WriteLine("ingrese el comienzo del rango");
            rangoinicio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el final del rango");
            rangofinal = Convert.ToInt32(Console.ReadLine());
            for (int i = rangoinicio ;i <= rangofinal ;i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} es multiplo de 5");
                }


            }
            

        }
    }
}
