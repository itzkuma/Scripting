using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDatos_UNION
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] U = new int[31] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30 } ;
            int[] A = new int[13] { 0,0,3,6, 6, 6, 9,12,12,12,15,18,18};
            int[] B = new int[16] { 0,0,2,2,4,6,6,6,8,10,12,12,14,16,18,18};
            int[] temp = new int[A.Length + B.Length];
            //se llena el arreglo temporal con los elementos de A.
            for (int i=0; i < A.Length; i++)
            {
                temp[i] = A[i];
            }
            //se llena el arreglo temporal con los elementos de B.
            for (int i = 0; i < B.Length; i++)
            {
                temp[A.Length+i] = B[i];
            }
            Array.Sort(temp);
            int cantidad = 0;
            for (int i = 0; i < temp.Length -1; i++)
            {
                if (temp[i] != temp[i + 1])
                {
                    cantidad++;
                }
            }
            int[] UNION = new int[cantidad];
            int pos = 0;
            for (int i = 0; i < temp.Length-1; i++)
            {
                if (temp[i] != temp[i + 1])
                {
                    UNION[pos]=temp[i];
                    pos++;
                }

            }

            Console.WriteLine("la union de A y B es:" );
            for (pos = 0; pos < UNION.Length; pos++)
            {
                Console.WriteLine(UNION[pos] + ",");
            }
        }
    }
}
