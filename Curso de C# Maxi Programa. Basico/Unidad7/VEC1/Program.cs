using System;

namespace VEC1
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
        // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.
        
        int[] vec = new int[10];
        int n, max = 0;
        int posición = 1;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero entero: ");
            n = int.Parse(Console.ReadLine());
            vec[x] = n;
        }

        max = vec[0];

        for (int x = 0; x < 10; x++)
        {
            if (vec[x] > max)
            {
                max = vec[x];
                posición = x + 1;
            }
        }
        
        Console.WriteLine("El valor máximo es: " + max);
        Console.WriteLine("La posición del valor máximo es: " + posición);

        }
    }
}