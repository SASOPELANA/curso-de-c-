using System;

namespace ejemplodowhile
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // CICLO DO WHILE.
        
        int n, con =0; 

        do
        {
          Console.WriteLine("Ingrese un numero: ");
          n = int.Parse(Console.ReadLine()); 
          con++;
        }while(n != 0);
        
        Console.WriteLine("Ingresaste: " + con + " numeros");

        }
    }
}
