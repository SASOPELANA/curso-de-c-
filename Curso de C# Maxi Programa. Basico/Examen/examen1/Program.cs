using System;

namespace examen1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vnros = new int[10];

            int aux = 0;

            for (int x = 0; x < 10; x++)
            {
                vnros[x] = int.Parse(Console.ReadLine());
            }

           for (int x = 0; x < 10; x++)
           {
                for (int y = 0; y < 9; y++)
                {
                    if (vnros[y] > vnros[y+1])
                    {
                        aux = vnros[y];
                        vnros[y] = vnros[y + 1];
                        vnros[y+1] = aux;
                    }
                }
            
           }

           Console.WriteLine("vector");
           for (int x = 0; x < 10; x++)
           {
            Console.WriteLine(vnros[x]);
           }

        }
    }
}