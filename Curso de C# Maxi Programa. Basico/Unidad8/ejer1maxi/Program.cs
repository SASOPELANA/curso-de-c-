
using System;

namespace ejer1maxi
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
        // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y 
        // muestre por pantalla el monto total a pagar. Usar la función.

        int n1, n2, prod;
        Console.WriteLine("Ingrese el precio de un articulo: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida del articulo: ");
        n2 = int.Parse(Console.ReadLine());
        
        prod = producto( n1, n2);
        
        Console.WriteLine("El monto total a pagar es de: $ " + prod);

        }

        static int producto( int a, int b)
        {
            int resultado = a * b;       // tambien sirve asi:
            return resultado;            // return a * b;
        }
    }
}