using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCondicionalesPalomaPlata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa en C# que determine el porcentaje de aumento salarial de un empleado según su evaluación anual y años trabajados.
            string nombre =" ";
            int años_trabajados = 0;
            float calificacion_actual = 0;
            float calificacion_anterior = 0;
            float promedioCal = 0;
            bool calificacion_valida = false;
            float sueldo_base = 2500000;
            float aumento = 0;
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese los años trabajados ");
            años_trabajados = Int32.Parse(Console.ReadLine ());
            Console.WriteLine("Ingrese la calificación del año actual");
            calificacion_actual= Single .Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la calificación del año anterior");
            calificacion_anterior = Single .Parse(Console.ReadLine());
            if ((calificacion_actual != 0 && calificacion_actual != 0.4 && calificacion_actual != 0.6 && calificacion_actual != 1)&&
               (calificacion_anterior != 0 && calificacion_anterior != 0.4 && calificacion_anterior != 0.6 && calificacion_anterior != 1) )
            {
                promedioCal = ((calificacion_actual + calificacion_anterior) / 2);
                calificacion_valida = true; ;
            }
            else
            {
                Console.WriteLine("Calificación inválida");
            }
            if (calificacion_valida)
            {
                if (años_trabajados < 5 && años_trabajados > 1)
                {
                    aumento = 0;
                }
                else if (años_trabajados > 5)
                {
                    aumento = 0.3f;
                }
                else if (años_trabajados <= 5 && años_trabajados < 0)
                {
                    if (promedioCal > 0 && promedioCal < 0.4)
                    {
                        aumento = 0.05f;
                    }
                    else if (promedioCal > 0.4 && promedioCal < 0.6)
                    {
                        aumento = 0.1f;
                    }
                    else if (promedioCal > 0.6 && promedioCal < 1)
                    {
                        aumento = 0.2f;
                    }

                }
                Console.WriteLine($"El trabajador {nombre} con calificacíon de {calificacion_actual} recibirá un aumento de {aumento*100}% ");
                Console.WriteLine($"El valor de su aumento es de {sueldo_base * aumento} pesos");
                
                
                
                
                
                
                


                
            }


        


        }
    }
}
