using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.CiclosDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    int contadornum = 1;
                int contador = 0;
                int divisores = 0;
                do
                {
                    do
                    {
                        if (contadornum % contador == 0)
                        {
                            divisores++;
                            contador++;
                        }
                    } while (contador <= contadornum);
                    contador=1 ;

                    if (divisores == 2)
                    {
                        Console.WriteLine(contadornum);
                    }
                    divisores = 0;
                    contadornum++;
                }while (contadornum <= 100);*/
/*            float a = 0;
            float b = 0;
            string op = "";
            bool boolexit = false;
            string exit = "";
           
            do
            {
                Console.WriteLine("Ingrese la operación(suma,resta,multiplicación, división)");
                op = Console.ReadLine();
                Console.WriteLine("Ingrese el 1er numero");
                a = Single.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el 2do número");
                b = Single.Parse(Console.ReadLine());

                switch (op)
                {
                    case "suma":
                        Console.WriteLine(a + b);
                        break;
                    case "resta":
                        Console.WriteLine(a - b);
                        break;
                    case "multiplicación":
                        Console.WriteLine(a * b);
                        break;
                    case "división":
                        Console.WriteLine(a / b);
                        break;

                }
                Console.WriteLine("Desea salir?(SI,NO)");
                exit = Console.ReadLine();
                if (exit == "SI")
                {
                    boolexit = true;
                }
                else if (exit == "NO")
                {
                    boolexit = false;
                }

            } while (boolexit == false);*/
            List <float> numeros = new List<float> { };
            string salida = " ";
            float num;
            bool exit = false;
            bool finlista=false;
            do
            {
             Console.WriteLine("Ingresar numero");
                num = Single.Parse(Console.ReadLine());
                numeros.Add (num);
             
            } while (finlista == false);






            
        
        
        
        
        }
    }
}


