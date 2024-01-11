using System;

namespace vecejemplo1

{
   class Program
   {
    static void Main(string[] args)
     {
        // Vectores. Arrayo o Arreglo.

        int n;
        int[] numeros = new int[10]; // asi se declara un vector para almacenar 10 datos o variables.
        //    0   1   2   3   4   5   6   7   8    9    --> Indices.
        // | 7  |   |   |   |   | 1 |   |   |    | 233
        
        /*
        int n = 1;
        numeros[6] = 1; // Dentro del corchete se pone el indice y luego se aigna el valor o variable.
        numeros[0] = 7;
        numeros[9] = 233;

        n = numeros[6] + numeros[0] + numeros[9] + n; // suma con los vectores.
        Console.WriteLine(numeros[0]); // para mostrar el valor de cada indice del vector, se debe indicar cual es; numeros[0], numeros[6]
        Console.WriteLine(n);
        */

        for (int x = 0; x < 10; x++) // Siempre ciclo FOR estandar, para los vectores.
        {
            Console.WriteLine("Ingrese la nota..."); // Forma de ingresar y guardar variables para usar con vectores.
            n = int.Parse(Console.ReadLine());
            numeros[x] = n;           
        }
        int acu = 0;
        for (int x = 0; x < 10; x++)
        {
            acu += numeros[x];
        } 
        int promedio = acu / 10; 

        for (int x = 0; x < 10; x++) // para mostrar lso valores se hace otro ciclo.
        {
            Console.WriteLine("El valor es: " + numeros[x]);
        }
        
     }

   } 

}