using System;

namespace ciclofor5
{
    class Program
    {
        static void Main(string[] args)
        {
            
        // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla 
        // el máximo de los números pares y el mínimo de los números impares.
        
        int n1, max = 0, min = 0;

        for (int x = 1; x <= 20; x++)
        {
		    Console.WriteLine("Ingrese un numero: ");
			n1 = int.Parse(Console.ReadLine());

            if (n1%2 == 0)
            {
                if (n1 > max)
                {
                    max = n1;
                }
            }
            else
            {
                if (n1 < min || min == 0)
                {
                  min = n1;  
                }
            }

        }
        
		Console.WriteLine("El máximo de los números pares es: " + max);
		Console.WriteLine("El mínimo de los números impares es: " + min);

        }
    }
}
