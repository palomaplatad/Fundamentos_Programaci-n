using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Arreglos_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numeros = new int [4];
            numeros[0] = 15;
            numeros[1] = 3;
            numeros[2] = 4;
            numeros[3] = 18;
            char[] simbolos = new char[] {'D','%', '#','t','w','i' };
            string[] estudiantes = new string[7];

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"INgrese un nombr apara la posicion {i + 1}");
                estudiantes[i]=Console.ReadLine(); 

            }
            for (int i = 0;i < numeros.Length ;i++)
            {
                Console.WriteLine(numeros [i]+'|');
            }
            int[]cien=new int[100];
            for (int i = 0; i < 100; i++) 
            {
                cien[i] = 10;
                Console.WriteLine(cien [i]); 

            }*/
            int[] nums = new int[15];
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Ingrese un nombr apara la posicion {i + 1}");
                nums[i] = Convert.ToInt32(Console.ReadLine());

            }
            for( int i = 0; i < 15; i++)
            {
                Console.WriteLine(nums[i]);
            }
            int max = nums[0];
            int posmax = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    posmax = i+1;


                }
           

             }
            Console.WriteLine($"Maximo: {max} Posicíon:{posmax}");
            int min= nums[0];
            int posmin = 0;
            for (int i = 1;i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i] ;
                    posmin = i+1;
                }
            }
            Console.WriteLine($"Minimo: {min} Posicíon:{posmin}"); 
        }
    }
}
