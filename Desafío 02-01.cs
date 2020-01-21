using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Desafío 02-01 por David Martínez");
            //Los datos que se ingresan son los catetos del triangulo
            Console.WriteLine("Ingrese los valores de y , z");
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            //calculando t (hipotenusa)
            Console.WriteLine("La hipotenusa del triangulo es:");
            double t = Math.Sqrt((y * y) + (z * z));
            Console.WriteLine(t);
            //calculando c (ángulo inferior del triangulo)
            Console.WriteLine(" El ángulo c del triangulo es:");
            double cgrados = Math.Acos( y / t);
            double c = cgrados * (180.0/ Math.PI);
            Console.WriteLine(c);
            //calculando a (ángulo superior del triangulo)
            Console.WriteLine("El ángulo a del triangulo es:");
            double agrados = Math.Acos(z / t);
            double a = agrados * (180.0 / Math.PI);
            Console.WriteLine(a);



        }
    }
}
