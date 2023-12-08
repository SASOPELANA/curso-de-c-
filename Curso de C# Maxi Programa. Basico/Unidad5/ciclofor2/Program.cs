using System;

namespace ciclofor2
{
    class Program
    {
        static void Main(string[] args)
        {
        // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. 
        // Solo se debe emitir UN valor por pantalla.
         
        int n1;
        float mayor = 0;

        for(int x = 1; x <= 10; x++)
        {
            Console.WriteLine( x + ". Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());

            if (mayor < n1)
            {
               mayor = n1; 
            }
        } 

        Console.WriteLine("El numero mayor es: " + mayor);

        }
    }
}