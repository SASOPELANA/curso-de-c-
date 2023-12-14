using System;

namespace cicloformaxi5
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla 
        // el máximo de los números pares y el mínimo de los números impares.
        
        int n1, maxp = 0, mini = 0;
        bool banp = false, bani = false;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1%2 == 0)
            {
                if (banp == false)
                {
                    maxp = n1;
                    banp = true;
                }else if (n1 > maxp)
                {
                    maxp = n1;
                }         
            }
            else
            {
                if (!bani)
                {
                    mini = n1;
                    bani = true;
                }else if (n1 < mini)
                {
                    mini = n1;            
                }   
            }
        }

        Console.WriteLine("El maximo de los numeros pares es: " + maxp + ".");
        Console.WriteLine("El minimo de los numeros impares es: " + mini + ".");

        }
    }
}