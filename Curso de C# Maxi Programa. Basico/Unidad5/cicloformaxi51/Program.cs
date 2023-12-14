using System;

namespace cicloformaxi51
{
    class Program
    {
        static void Main(string[] args)
        {

        // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla 
        // el máximo de los números pares y el mínimo de los números impares.
        
        int n1, max = 0, min = 0;
        int conpar = 0, conimpar = 0;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese un numero ");
            n1 = int.Parse(Console.ReadLine());
            if (n1%2 == 0)
            {
                conpar++;
                if(conpar == 1)
                   max = n1;
                else if(n1 > max)
                   max = n1;
            }else
            {
                conimpar++;
                if(conimpar == 1)
                   min = n1;
                else if(n1 < min)
                   min = n1;
            }
        } 
        Console.WriteLine("El mámximo par es: " + max);
        Console.WriteLine("El minimo impar es: " + min);
        }
    }
}