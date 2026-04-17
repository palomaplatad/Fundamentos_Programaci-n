using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*            int[,] nums=new int[2,3];
            string[,] nombres =
            {
                {"Laura","ana" },
                {"Juan","Carlos"},
                {"yuli","esteban" }
            };*/
            int[,] mat1=new int[2,3];
            int[,] mat2 = new int[2, 3];
            int[,] sum = new int[2, 3];
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(0); j++)
                {
                    Console.WriteLine($"Ingrese el valor para matriz1 [{i},{j}]");
                    mat1[i,j]=int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < mat2.GetLength(0); i++)
            {
                for (int j = 0; j < mat2.GetLength(0); j++)
                {
                    Console.WriteLine($"Ingrese el valor para matriz1 [{i},{j}]");
                    mat2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0;i < sum.GetLength(0); i++)
            {
                for (int j = 0;j < sum.GetLength(0); j++)
                {
                    sum[i, j] = mat1[i, j] + mat2[i, j];
                }
            }




        }
    }
}
