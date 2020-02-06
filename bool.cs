using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @bool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("ingrese los valores de a, b, blancos, anulados, n , p");
            int votospartido1 = int.Parse (Console.ReadLine());
            int votospartido2 = int.Parse(Console.ReadLine());
            int blancos = int.Parse(Console.ReadLine());
            int anulados = int.Parse(Console.ReadLine());
            int numerototaledades = int.Parse(Console.ReadLine());
            int porcentajemayoredad = int.Parse(Console.ReadLine());
            int mayoredad = numerototaledades * porcentajemayoredad;
            int votostotales = (votospartido1 + votospartido2 + blancos + anulados);
            int abstencion = votostotales - mayoredad;

            bool a = anulados < 0.30 *(votospartido1 +votospartido2);
            bool b = (votospartido1 + votospartido2) > blancos;
            bool c = abstencion < votostotales;
            bool d = (votospartido1 > votospartido2);
            bool e = (votospartido1 < votospartido2);
            if (((a || b) && (c)) && (d))
            {
                Console.WriteLine("Las elecciones fueron EXITOOOoOoO");
                Console.WriteLine("ganador elecciones: a");

            }

            else if (((a || b) && (c)) && (e))
            {
                Console.WriteLine("Las elecciones fueron EXITOOOoOoO");
                Console.WriteLine("ganador elecciones: b");

            }

            else
            {
                Console.WriteLine("Las votaciones deben ser realizadas nuevamente");
            }

            
            



        }
    }
}
