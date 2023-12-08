using System;

namespace ejemplowhile
{
    class Program
    {
        static void Main(string[] args)
        {
        // CICLO WHILE
        // Este ciclo funciona mientras la condicion de cumpla.
        // Este ejemplo de ciclo while, se corta con cero (0)

        int n, con = 0; 

        Console.WriteLine("Ingrese un numero: ");
        n = int.Parse(Console.ReadLine());

        while(n != 0){
             con++;
             Console.WriteLine("Ingrese un numero: ");
             n = int.Parse(Console.ReadLine());

        }
        
        Console.WriteLine("Ingresaste: " + con + " numeros.");
       
        }
    }
}
