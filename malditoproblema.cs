using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximominimo
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("ingrese el numero de datos (n):");

            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string nombremax = ("");
            string nombremin = ("");

            while (i < n)
            {
                Console.Write("nombre:");
                string nombre = (Console.ReadLine());
                Console.Write("edad:");
                int edad = int.Parse(Console.ReadLine());

                if (edad > max)
                {
                    max = edad;
                    nombremax = nombre;
                
                }
                if (edad < min)
                {
                    min = edad;
                    nombremin = nombre;
                }

                total += edad;

                i++;
            }
            double promedio = total / n;
            Console.WriteLine("promedio=" + promedio);
            Console.WriteLine(nombremax  + max);
            Console.WriteLine(nombremin + min);
        }
    }
}
