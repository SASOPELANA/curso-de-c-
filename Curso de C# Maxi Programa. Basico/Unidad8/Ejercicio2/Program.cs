using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
        // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
        
        int num, con = 0, los2; 

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Diguite un numero: ");
            num = int.Parse(Console.ReadLine());

            los2 = par(num);
            if (los2 == 1)
            {
                con++;
            }
        }
        
        Console.WriteLine("La cantidad de numeros pares ingresado son: " + con);

        }

        static int par( int n1)
        {
           int a, b;
           if (n1 % 2 == 0)
           {
            a = 1;
            return a;
           }else 
           {
            b = 0;
            return b;
           }
        }
    }
}