using System;

namespace actividad_cinco
{
    class Program
    {
        static void Main(string[] args)
        {
         //Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.
         
         float n1, n2, n3, nota, final;

         Console.WriteLine("Ingrese la primera nota: ");
         n1 = float.Parse(Console.ReadLine());

         Console.WriteLine("Ingrese la segunda nota: ");
         n2 = float.Parse(Console.ReadLine());


        Console.WriteLine("Ingrese la tercera nota: ");
         n3 = float.Parse(Console.ReadLine()); 

         // (n1 + n2 + n3) / 3   asi para resolver el ejercicio de una vez, 

        nota = n1 + n2 + n3; 
        final = nota / 3;

        Console.WriteLine("El promedio final del alumno es: " + final.ToString("0.00"));

        // Ctrl + F2 para cambiar todos los datos a la ves

        }
    }
}
