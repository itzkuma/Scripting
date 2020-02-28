using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edades_nombres
{
    class Program
    {
        static void Main(string[] args)
        {
            int e= 0;


            Console.WriteLine("ingrese el numero de datos que va a escribir");
            e = int.Parse (Console.ReadLine());
            int[] edades = new int[e];
            //string n = " ";
            string[] nombres = new string[e];

            //Console.WriteLine("ingrese el numero de nombres que va a escribir");
            //n= (Console.ReadLine());

            for  (e =0; e < edades.Length; e++)
            {
                Console.WriteLine("Edad: ");
                edades[e] = int.Parse(Console.ReadLine());
                Console.WriteLine("Nombre: ");
                nombres[e] = Console.ReadLine();
            }
            //calculando el nombre y la edad del mayor
            int max = 0;
            string indice = " ";
            for(e =0; e< edades.Length; e++)
            {
               if(edades[e]> max)
               {
                max = edades[e];
                 indice =  (nombres[e]);
                
               }
                
            }
            Console.WriteLine("el mayor es: " + indice + "con una edad de: " + max);

            //calculando el nombre y la edad del menor
            int min = 0;
            string indice1 = " ";
            for (e = 0; e < edades.Length; e++)
            {
                if (edades[e]< min)
                {
                    min = edades[e];
                    indice1 = nombres[e];

                }

            }
            Console.WriteLine("el menor es: " + indice1 + "con una edad de: " + min);
        }

    }
}
