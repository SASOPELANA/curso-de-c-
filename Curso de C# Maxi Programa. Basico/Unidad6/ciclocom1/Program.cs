using System;

namespace ciclocom1
{
    class Program
    {
        static void Main(string[] args)
        {
        // 1. Hacer un programa para ingresar 10 números. 
        // El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
        
        int n1, con, ptotal = 0;

        for (int x = 0; x < 10; x++)
        {
            con = 0;
            Console.WriteLine(" Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n1; i++)
            {
               if (n1 % i == 0)
               {
                con++;
               } 
            }
            if (con == 2)
            {
               ptotal++; 
            }
        }       
        if (ptotal != 0)
        {
            Console.WriteLine("En total se ingreso, " + ptotal + " numero primos.");
        }

        Console.WriteLine("--FIN DEL PROGRAMA--");
       
        }
    }
}