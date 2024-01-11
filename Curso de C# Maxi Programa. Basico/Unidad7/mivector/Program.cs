using System;

namespace mivector

{
       class Program
    {
       static void Main()
        {
           int[] vector = new int[10]; // Asi de declara un vector.  // o asi tambien // int[] miVector = { 1, 2, 3, 4, 5 };
           int n, acu = 0, promedio;

           for (int x = 0; x < 10; x++) // Siempre estructura estandar en el ciclo For para los vectores.
           {
            Console.WriteLine("Ingrese numeros hasta: "); // Asi se ingresa numeros en el vector y se lo guarda.
            n = int.Parse(Console.ReadLine());
            vector[x] = n;
           }
           Console.WriteLine("Mostrar los elemntos del vector: "); 

           for (int x = 0; x < 10; x++) // forma de mostrar los elemntos del vector.
           {
            Console.WriteLine(vector[x]); 
           }

           for (int x = 0; x < 10; x++) // Sacar promedio.
           {
            acu += vector[x];
           }

           promedio = acu / 10;

           Console.WriteLine("El promedio es: " + promedio);

        }
    }
}
