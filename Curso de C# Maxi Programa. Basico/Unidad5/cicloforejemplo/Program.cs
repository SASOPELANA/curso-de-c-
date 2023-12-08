using System;

namespace cicloforejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // Ciclo FOR
        
        // for(int x = 0; x < 5; x++){     // Estructura estandar del Ciclo FOR.
        //     Console.WriteLine("HOLA MUNDO " + x);
        // }

        // ---------------------------------------------------------------------

        // Forma de ingresar numeros o variables en los ciclos.

        // int n;        
        // for (int x = 0; x < 5; x++)
        // {
        //     Console.WriteLine("Ingrese un numero");
        //     n = int.Parse(Console.ReadLine());   
        // }

        // ---------------------------------------------------------------------

        // CICLO FOR CON ACUMULADOR Y SUMAS.
        // Hacer un programa para ingresar 5 notas y mostrar el promedio final, usando ciclo FOR.

        int n = 0, promedio, suma = 0;        

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Ingrese la notas");
            n = int.Parse(Console.ReadLine()); 
            suma += n;  // Operdaor de acumulacion, lo mismo es; suma = suma + n;
        }

        promedio = suma / 5;

        Console.WriteLine("El promedio de nota es: " + promedio);
       
        }
    }
}