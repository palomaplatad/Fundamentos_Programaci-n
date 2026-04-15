using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] nums = new int[15];
            for (int i = 0; i < nums.Length; i++)
               {
                   Console.WriteLine($"Ingrese el número {i+1}");
                   nums[i] = Convert.ToInt32(Console.ReadLine());
               }
               int min = nums[0];
               int max = nums[0];
               for (int i = 0; i < nums.Length; i++)
               {
                   if (nums[i] < min)
                   {
                       min = nums[i]; 
                   }
                   else if (nums[i] > max)
                   {
                       max = nums[i];
                   }
               }
               Console.WriteLine($"El maximo es:{max} y el minimo: {min}");*/
            /*            int rango = 0;
                        Console.WriteLine("Cuantos caracteres va a ingresar?");
                        rango = Convert.ToInt32(Console.ReadLine());
                        char[] chars = new char[rango];
                        char[] charsinvertido = new char[rango];
                        for (int i = 0; i < chars.Length; i++)
                        {
                            Console.WriteLine($"Ingrese el caracter {i+1}");
                            chars[i]= char.Parse ( Console.ReadLine() );
                        }
                        for (int i = 0;i < chars.Length; i++)
                        {
                            charsinvertido [i] = chars[chars.Length - 1 - i];
                        }
                        for (int i = 0; i < chars.Length; i++)
                        {
                            Console.Write(charsinvertido[i]);
                        }*/
            int[] adivina = new int[20];
            for (int i = 0; i < adivina.Length; i++)
            {
                Random randint = new Random();
                adivina[i] = randint.Next(0,51) ;
            }
            int adivinanza= 0;
            Console.WriteLine("Adivine el número");
            adivinanza = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 20 ; i++)
            {
                if (adivinanza == adivina[i])
                {
                    Console.WriteLine(
                }  
            }















        }
    }
}
