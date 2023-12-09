using System;

namespace ciclofor4
{
    class Program
    {
        static void Main(string[] args)
        {
        // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. 
        // Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
        int n1, con = 0;

        Console.WriteLine("Ingrese un numero: ");
        n1 = int.Parse(Console.ReadLine());
        
        for (int x = 1; x <= n1; x++)
        {
        if (n1 % x == 0)
        {
            con++;
        }  
        }
        if (con == 2)
        {
        Console.WriteLine(n1 + " es un numero primo.");   
        }else{
        Console.WriteLine(n1 + " no es un numero primo.");  
        }
       
        }
    }
}