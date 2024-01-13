using System;

namespace VEC2
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector.
        // Luego recorrer ese vector para calcular el promedio.
        // Mostrar por pantalla los valores que son mayores al promedio.

        int[] vec = new int[10];

        for (int x = 0; x < 10; x++)
        {
           Console.WriteLine("Ingrese numeros enteros: ");
           vec[x] = int.Parse(Console.ReadLine());
        }

        int acuv = 0, pro;
        for (int x = 0; x < 10; x++)
        {
            acuv += vec[x];
        }
        pro = acuv / 10;
        Console.WriteLine("El promedio es: " + pro);
       
        for (int x = 0; x < 10; x++)
        {
            if (vec[x] > pro)
            {
                Console.WriteLine("Los valores mayores al promedio son: " + vec[x]);
            }
        }

        }
    }
}
