using System;

namespace Condicionales15
{
    class Program
    {
        static void Main(string[] args)
        {
        // 5. Hacer un programa para ingresar 4 números. 
        // Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
        
       int n1, n2, n3, n4;

       Console.WriteLine("Ingrese un numero: ");
       n1 = int.Parse(Console.ReadLine());
       Console.WriteLine("Ingrese un segundo: ");
       n2 = int.Parse(Console.ReadLine());
       Console.WriteLine("Ingrese un tercer: ");
       n3 = int.Parse(Console.ReadLine());
       Console.WriteLine("Ingrese un cuarto: ");
       n4 = int.Parse(Console.ReadLine());

       if(n1 > n2 && n2 > n3 && n3 > n4){
              Console.WriteLine("Los numeros estan ordenados de forma decreciente.");
       }else
       {
              Console.WriteLine("Los numeros estan desordenados.");
       }
           
       Console.WriteLine(" ");
       Console.WriteLine("--FIN DEL PROGRAMA--");
        }
    }
}