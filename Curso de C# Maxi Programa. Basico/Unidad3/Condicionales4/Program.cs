using System;

namespace Condicionales4
{
    class Program
    {
        static void Main(string[] args)
        {
         // 4. Hacer un programa para ingresar cuatro números distintos y 
         // luego mostrar por pantalla el menor de ellos.

        int n1, n2, n3, n4; 

        Console.WriteLine("Ingrese un numero:");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un segundo numero:");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un tercer numero:");
        n3 = int.Parse(Console.ReadLine()); 

        Console.WriteLine("Ingrese un cuarto numero:");
        n4 = int.Parse(Console.ReadLine());

        if(n1 <n2 && n1 < n3 && n1 < n4){
            Console.WriteLine(n1 + " Es el menor de los numeros");
        }else if(n2 < n1 && n2 < n3 && n2 < n4){
            Console.WriteLine(n2 + " Es el menor de los numeros");
        }else if(n3 < n1 && n3 < n2 && n3 < n4){
            Console.WriteLine(n3 + " Es el menor de los numeros");
        }else{
            Console.WriteLine(n4 + " Es el menor de los numeros");
        }
   
        }
    }
}