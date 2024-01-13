using System;

namespace VEC2MAXI
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector.
        // Luego recorrer ese vector para calcular el promedio.
        // Mostrar por pantalla los valores que son mayores al promedio.

        int[] numeros = new int[5];
        int promedio, acumulador = 0;

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Digite un numero: ");
            numeros[x] = int.Parse(Console.ReadLine());
        }
        
        for (int x = 0; x < 5; x++)
        {
            acumulador += numeros[x];
        }
        promedio = acumulador / 5;
        Console.WriteLine("El promedio es: " + promedio);

        for (int x = 0; x < 5; x++)
        {

           if (numeros[x] > promedio)
           {
            Console.WriteLine("Los valores que son mayor al promedio son: " + numeros[x]);
           }
        
        }

        }
    }
}