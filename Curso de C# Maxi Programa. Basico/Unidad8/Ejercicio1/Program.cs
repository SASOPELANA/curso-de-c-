using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

        // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
        // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. 
        // Usar la función.
        
        // ACTIVIDAD 1

        int n1, n2, mul = 0;

        Console.WriteLine("Diguite un numero: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Diguite otro numero: ");
        n2 = int.Parse(Console.ReadLine());

        mul = producto(n1, n2);

        Console.WriteLine("El producto de los numeros ingresados es: " + mul);

        // ACTIVIDAD 2

        int precioArt, canVen, acu = 0, pagar = 0;

        Console.WriteLine("Ingrese el precio del articulo elegido: ");
        precioArt = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida del prodcuto: ");
        canVen = int.Parse(Console.ReadLine());
        
        while (canVen != 0)
        {
            acu += canVen;
            Console.WriteLine("Ingrese la cantidad vendida del prodcuto o cero (0) para terminar: ");
            canVen = int.Parse(Console.ReadLine());
            
        }

        pagar = producto(precioArt, acu);

        Console.WriteLine("El monto total a pagar es: " + pagar);
 
        }
        // Funcion 1
        static int producto( int nun1, int num2)
        {
            int resultado;
            resultado = nun1 * num2;
            return resultado;

        }
        
    }
}