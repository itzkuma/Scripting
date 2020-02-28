using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDatos_COMPLEMENTO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> U = new List<int>(31) { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            List<int> A = new List<int>(13) { 0, 0, 3, 6, 6, 6, 9, 12, 12, 12, 15, 18, 18 };
            List<int> B = new List<int>(16) { 0, 0, 2, 2, 4, 6, 6, 6, 8, 10, 12, 12, 14, 16, 18, 18 };
            List<int> todos = new List<int>();
            List<int> complemento = new List<int>();

            for (int i = 0; i < A.Count; i++)
            {
                todos.Add(A[i]);
            }
            //se llena el arreglo todos con los elementos de B.
            for (int i = 0; i < B.Count; i++)
            {
                todos.Add(B[i]);
            }

            for (int i = 0; i < U.Count; i++)
            {
                if (todos.IndexOf(U[i]) == -1)
                {
                    complemento.Add(U[i]);
                }
            }
            for (int i = 0; i < complemento.Count; i++)
            {
                Console.WriteLine((complemento[i]) + ",");
            }
            
           
        }
    }
}
  

