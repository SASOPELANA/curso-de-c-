using System;

namespace Condicionales5maxi
{
    class Program
    {
        static void Main(string[] args)
        {
        // 5. Hacer un programa para ingresar cuatro números y 
        // luego mostrar por pantalla cuáles son mayores a 100.

        // Ejemplo maxiprograma usando contador ++;

        float n1, n2, n3, n4, contador = 0;

        Console.WriteLine("Digite un numero:");
        n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite un segundo numero:");
        n2 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite un tercer numero:");
        n3 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite un cuarto numero:");
        n4 = float.Parse(Console.ReadLine());

        if(n1 > 100){
            Console.WriteLine(n1);
            contador++;
        }
        if(n2 > 100){
            Console.WriteLine(n2);
            contador++;
        }
        if(n3 > 100){
            Console.WriteLine(n3);
            contador++;
        }
        if(n4 > 100){
            Console.WriteLine(n4);
            contador++;
        }
        if(contador != 0)
            Console.WriteLine("Son mayores a 100...");
        
        Console.WriteLine("Fin del programa");

        }
    }
}