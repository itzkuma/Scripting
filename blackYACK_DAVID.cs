using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackYACK
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, total = 0;
            int carta2 = 0;
            string continuar = "s";
            string sacarCarta = "s";
            int Jugadores = 0;
            int ind_ganador = 0;
            bool ganador = false;
            bool TodosLost = false;
            int count_perdedores = 0;


            Console.WriteLine("Ingrese el número de jugadores");
            Jugadores = int.Parse(Console.ReadLine());
            List<string> nombres = new List<string>();
            List<int> puntaje = new List<int>();
            List<bool> perdedores = new List<bool>();
            List<int> mas21 = new List<int>();
            List<string> nombresMas21 = new List<string>();
            for (int i = 0; i < Jugadores; i++)
            {
                perdedores.Add(false);
                //hago todas las posciociones de perdedores falsas
            }
            for (int i = 0; i < Jugadores; i++)
            {
                Console.WriteLine("Ingrese el nombre del jugador " + (i + 1));
                nombres.Add(Console.ReadLine());
            }

            for (int i = 0; i < Jugadores; i++)
            {
                carta = aleatorio.Next(1, 10);
                carta2 = aleatorio.Next(1, 10);
                Console.WriteLine("primera carta " + nombres[i] + ": " + carta);
                Console.WriteLine("segunda carta " + nombres[i] + ": " + carta2);
                puntaje.Add(carta + carta2);
                Console.WriteLine("total:" + puntaje[i]);

            }

            while (continuar == "s" && sacarCarta == "s" && ganador == false && TodosLost == false)
            {
                count_perdedores = 0;
                for (int i = 0; i < Jugadores; i++)
                {
                    if (perdedores[i] == true) count_perdedores++;
                }
                if (count_perdedores == perdedores.Count)
                {
                    TodosLost = true;
                }
                if (TodosLost == true)
                {
                    Console.WriteLine("Juego finalizado");
                    continuar = "n";
                    break;
                }
                for (int i = 0; i < Jugadores; i++)
                {
                    if (perdedores[i] == false)
                    {
                        Console.WriteLine(nombres[i] + " deseas sacar una carta?(s/n)");
                        sacarCarta = Console.ReadLine();
                        if (continuar == "s" && sacarCarta == "s" && puntaje[i] < 21)
                        {
                            carta = aleatorio.Next(1, 10);
                            Console.WriteLine("carta:" + carta);
                            puntaje[i] += carta;
                            Console.WriteLine("Total: " + puntaje[i]);
                            if (puntaje[i] > 21)
                            {
                                Console.WriteLine("perdiste!...ya no puedes continuar... total=" + puntaje[i]);
                                perdedores[i] = true;
                            }
                            else if (puntaje[i] == 21)
                            {
                                Console.WriteLine("Ganaste " + nombres[i] + "!!");

                                continuar = "n";
                                ganador = true;
                                break;
                            }
                        }

                    }
                }
            }
            //metodo de ordenamiento por burbuja
            int tmp;
            string nombreTMP;
            for (int a = 1; a < puntaje.Count; a++)//comienza en la  primera poscicion de la lista
                for (int b = puntaje.Count - 1; b >= a; b--) //comienza en la  ultima poscicion de la lista
                {
                    if (puntaje[b - 1] < puntaje[b]) //organiza de  mayor a menor los puntajes
                    {
                        tmp = puntaje[b - 1];
                        nombreTMP = nombres[b - 1];
                        puntaje[b - 1] = puntaje[b];
                        nombres[b - 1] = nombres[b];
                        puntaje[b] = tmp;
                        nombres[b] = nombreTMP;                   
                    }
                }
            //ordena los puntajes mayores a 21
            for (int a = 1; a < puntaje.Count; a++)//comienza en la  primera poscicion de la lista
                for (int b = puntaje.Count - 1; b >= a; b--) //comienza en la  ultima poscicion de la lista
                {
                    if (puntaje[b] > 21) 
                    {
                        tmp = puntaje[b - 1];
                        nombreTMP = nombres[b - 1];
                        puntaje[b - 1] = puntaje[b];
                        nombres[b - 1] = nombres[b];
                        puntaje[b] = tmp;
                        nombres[b] = nombreTMP;
                    }
                }
            
                Console.WriteLine("Tabla de posciciones:");
            for (int a = 0; a < puntaje.Count; a++)
            {
                if (puntaje[a]>21)
                {
                    mas21.Add(puntaje[a]);
                    nombresMas21.Add(nombres[a]);
                    puntaje.RemoveAt(a);
                    nombres.RemoveAt(a);

                }         
            }
            for (int a = 0; a < puntaje.Count; a++)
            {
                Console.WriteLine(nombres[a] + ":" + puntaje[a]);
            }
            
            {
            for (int a = 0; a < mas21.Count; a++)
            {
                Console.WriteLine(nombresMas21[a] + ":" + mas21[a]);
            }
        }
            }
    }
}