using System;

namespace Condicionales4maxi
{
    class Program
    {
        static void Main(string[] args)
        {
         // 4. Hacer un programa para ingresar cuatro números distintos y 
         // luego mostrar por pantalla el menor de ellos.

        int n1, n2, n3, n4, menor; 

        Console.WriteLine("Ingrese un numero:");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un segundo numero:");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un tercer numero:");
        n3 = int.Parse(Console.ReadLine()); 

        Console.WriteLine("Ingrese un cuarto numero:");
        n4 = int.Parse(Console.ReadLine());

        if(n1 < n2)
           menor = n1;
        else
           menor = n2;

        if(n3 < menor)      
           menor = n3;

        if(n4 < menor)
           menor = n4;

        Console.WriteLine("El numero menor es: " + menor);

        }
    }
}
