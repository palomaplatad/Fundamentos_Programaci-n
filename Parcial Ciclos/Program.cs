using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            int tiene_cuatro = 0;
            int tiene_cinco = 0;
            int tiene_seis = 0;
            for (int i = 1; i <= 15;  i++)
            {
                Console.WriteLine($"Ingrese la edad del alumno {i} ");
                edad= Convert.ToInt32( Console.ReadLine() );
                if (edad == 4)
                {
                    tiene_cuatro++;
                }
                else if (edad == 5)
                {
                    tiene_cinco++;
                }
                else if (edad == 6)
                {
                    tiene_seis++;
                }
                else
                {
                    Console.WriteLine("Edad fuera del rango");
                    break;
                }
            }
            float promedio = (((tiene_cuatro *4)+(tiene_cinco*5)+(tiene_seis *6))/15);
            string gp_mayor = "";
            string gp_menor = "";
            Console.WriteLine($"El promedio de edad de la clase es de {promedio}");
            Console.WriteLine($"{tiene_cuatro} estudiantes tienen 4 años");
            Console.WriteLine($"{tiene_cinco} estudiantes tienen 5 años");
            Console.WriteLine($"{tiene_seis} estudiantes tienen 6 años");
            if (tiene_cuatro > tiene_seis)
            {
                if (tiene_cuatro > tiene_cinco)
                {
                    gp_mayor = "4 años";
                    gp_menor = tiene_seis > tiene_cinco ? "5 años" : "6 años";
                }
                else
                {
                    gp_mayor = "5 años";
                    gp_menor = "6 años";
                }
            }
            else
            {
                if(tiene_seis>tiene_cinco)
                {
                    gp_mayor = "6 años";
                    gp_menor = tiene_cuatro > tiene_cinco ? "5 años" : "4 años";
                }
                else
                {
                    gp_mayor = "5 años";
                    gp_menor = "4 años";
                }
            }
            Console.WriteLine($"El grupo mayor tiene {gp_mayor} y el grupo menor tiene {gp_menor}");


        }
    }
}
