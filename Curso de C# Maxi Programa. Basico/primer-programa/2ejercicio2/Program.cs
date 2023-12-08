using System;

namespace _2ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Hacer un programa para solicitar por teclado un numero y luego devolver su valor elevado al cubo.

           int numero1, resultado;

           Console.WriteLine("Ingreese un numero");
           numero1 = int.Parse(Console.ReadLine());

           resultado = numero1 * numero1 * numero1;

           Console.WriteLine("El numero ingresado elevado al cubo es: " + resultado);








        }
    }
}
