using System;

namespace Condicionales11
{
    class Program
    {
        static void Main(string[] args)
        {
         // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
         // La resta si el primero es mayor que el segundo.
         // La suma si son iguales.
         // El producto si el primero es menor.
         // Se deberá emitir un cartel por pantalla con el resultado correspondiente. 
        
        float n1, n2, resultado = 0;

        Console.WriteLine("Ingrese un numero:");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero:");
        n2 = float.Parse(Console.ReadLine());

        if(n1 > n2){
            resultado = n1 - n2;
            Console.WriteLine("La resta es: " + resultado);
        }
        if(n1 == n2){
            resultado = n1 + n2;
            Console.WriteLine("La suma es: " + resultado);
        }else if(n1 < n2){
            resultado = n1 * n2;
            Console.WriteLine("El producto es: " + resultado);
        }

        Console.WriteLine("Fin del programa");
        }
    }
}