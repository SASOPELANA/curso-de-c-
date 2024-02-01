using System;

namespace PorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int n1 = 0, n2 = 0, resultado;

        pedirDatos(ref n1, ref n2);

        resultado = sumar(n1, n2);
     
        Console.WriteLine("El resultado es: " + resultado);    

        }

        static int sumar(int a, int b) // Paramateros por valor 
        {
            int r;
            r = a + b;
            return r;
        }

        static void pedirDatos( ref int j, ref int h) // Parametros por referencia. La funcion void no retorna valores.
        {
        Console.WriteLine("Ingrese el primer numero: ");
        j = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        h = int.Parse(Console.ReadLine());
        }
        
    }
}