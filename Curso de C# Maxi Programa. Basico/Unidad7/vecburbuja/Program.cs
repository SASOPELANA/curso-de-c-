using System;

namespace vecburbuja
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se ingresa una lista de 20 números en un vector. 
            // Se pide ordenar dichos números en forma decreciente (de mayor a menor). 
            // Mostrar el listado ordenado informando también la posición original de cada número en el vector.

        int n, aux;
        int[] vecnumeros = new int[20];
        int[] vecposiciones = new int[20];

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese numeros: ");
            n = int.Parse(Console.ReadLine());
            vecnumeros[x] = n;
        }
        for (int x = 0; x < 20; x++)
        {
            vecposiciones[x] = x + 1;
        }
        for (int y = 0; y < 20; y++) // Metodo Burbuja.
        {
            for (int x = 0; x < 19; x++)
            {
                if (vecnumeros[x] < vecnumeros[x + 1])
                {
                    aux = vecnumeros[x + 1];
                    vecnumeros[x + 1] = vecnumeros[x];
                    vecnumeros[x] = aux;
                    aux = vecposiciones[x + 1];
                    vecposiciones[x + 1] = vecposiciones[x];
                    vecposiciones[x] = aux;
                }   
            }
        } // Hasta aqui metodo Burbuja.

        for (int x = 0; x < 20; x++) // Mostrar resultados.
        {
           Console.WriteLine("Lista ordenada: " + vecnumeros[x]);
           Console.WriteLine("Lista de posicion original: " + vecposiciones[x]); 
        }
   
        }
    }
}



