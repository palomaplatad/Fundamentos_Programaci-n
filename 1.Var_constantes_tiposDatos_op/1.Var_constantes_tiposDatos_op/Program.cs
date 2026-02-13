using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Var_constantes_tiposDatos_op
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int d1 = 5;
            int d2 = -d1;
            Console.Write(d1 + "//" + d2);
            //Aritmericos
            int d3 = 5 + 6;
            int d4 = 120 - 231;
            int d5 = 12 * 56;
            float  d6 = 5 / 3f;
            Console.Write("\nSuma:{0},Resta:{1},Multiplicacion:{2},Divisiom:{3}", d3, d4, d5, d6);
            //Incremento y Decremento
            d3++;
            Console.WriteLine(" Incremento:" + d3);
            d4--;
            Console.WriteLine("Decremento:" + d4);
            d5 += 4;
            d3 -= 5;
            d5 *= d3;
            d6 /= d3;
            //Orden evaluacion Operadores numericos
            float d7 = 4 * 3 / 2;
            float d8 = 4.0f * (3.0f / 2.0f);
            float d9 = 4 + 6 * (2 - 1);

            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);







        }
    }
}
