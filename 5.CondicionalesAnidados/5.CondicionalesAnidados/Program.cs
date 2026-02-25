using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*          int A = 0;
                        int B = 0;
                        int C = 0;*/
            /*Console.WriteLine("Ingrese el numero 1");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 3");
            C = Convert.ToInt32(Console.ReadLine());

            if (A > B)
            {
                if (A > C)
                {
                    Console.WriteLine($"El número mayor es: {A}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {C}");
                }
            }

            else
            {
                if (B > C)
                {
                    Console.WriteLine($"El número mayor es: {A}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {A}");
                }


                

            }*/
            float calificacion1 = 0.0f;
            float calificacion2 = 0.0f;
            float calificacion3 = 0.0f;
            Console.WriteLine("Ingrese las 1era calificación");
            calificacion1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las 2da calificación");
            calificacion2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese las 3era calificación");
            calificacion3 = float.Parse(Console.ReadLine());
            float avg = (calificacion1 + calificacion2 + calificacion3) / 3f;
            if (avg > 9.5 && avg < 10)
            {
                Console.WriteLine("Excelente");
            }
            else if (avg > 8.5 && avg < 9.4)
            {
                Console.WriteLine("Muy Bien");
            }
            else if (avg > 7.5 && avg < 8.4)
            {
                Console.WriteLine("Bien");
            }
            else
            {
                Console.WriteLine("Error, el promedio no esta en los rangos establecidos");
            }




        }
     }
   
}
