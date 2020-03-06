using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarPalabra
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = " "; // entrada del usuario
            int total= 0;
            frase = frase.ToUpper();
            Console.WriteLine("ingrese la frase:");
            frase = Console.ReadLine();

            string[] palabras = frase.Split(' ');
            string palabraBuscada; // entrada del usuario

            
            Console.WriteLine("Ingrese la palabra que busca");
            palabraBuscada = Console.ReadLine();

            for (int i=0; i <palabras.Length; i++)
            {
                //palabraBuscada= palabras[i];
                if (palabraBuscada == palabras[i])
                {
                    Console.WriteLine(" se encontró " + palabraBuscada +" en la poscición" + i);
                    total++;
                    Console.WriteLine("se repite" + total+ "veces");
                }

            }
           
        }
    }
}
