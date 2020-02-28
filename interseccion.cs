using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDatos_INTERSECCION
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] U = new int[31] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int[] A = new int[13] { 0, 0, 3, 6, 6, 6, 9, 12, 12, 12, 15, 18, 18 };
            int[] B = new int[16] { 0, 0, 2, 2, 4, 6, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };
            List<int> interseccion = new List<int>();
            //se llena el arreglo temporal con los elementos de A.
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        interseccion.Add(A[i]);
                    }
                }
            }
            interseccion.Sort();
            for (int i=0; i <interseccion.Count -1; i++)
            {
                if (interseccion[i] == interseccion[i + 1])
                {
                    interseccion.RemoveAt(i);
                    i = 0;
                }
            }
            for (int i = 0; i < interseccion.Count - 1; i++)
            {
                if (interseccion[i] == interseccion[i + 1])
                {
                    interseccion.RemoveAt(i);
                    i = 0;
                }
            }


            Console.WriteLine("la interseccion entre A y B es:");
            for (int i = 0; i < interseccion.Count; i++)
            {
                Console.WriteLine(interseccion[i] + ",");
            }
        }
    }
}
