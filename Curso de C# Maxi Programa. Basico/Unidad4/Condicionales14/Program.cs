using System;

namespace Condicionales14
{
    class Program
    {
        static void Main(string[] args)
        {

        // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
        // si la suma de los dos primeros es mayor al producto del segundo con el tercero.  
        
        int n1, n2, n3;
        float suma, prodcuto;

        Console.WriteLine("Ingrese un numero: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un segundo: ");
        n2 = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Ingrese un tercer: ");
        n3 = int.Parse(Console.ReadLine());

        suma = n1 + n2;
        prodcuto = n2 * n3;

        // if((n1 + n2) > (n2 * 23))

        if(suma > prodcuto){
            Console.WriteLine("La suma de los dos primeros numeros, es mayor al producto del segundo con el tercero.");
        }else if(suma == prodcuto) 
        {
            Console.WriteLine("La suma y el productos son iguales.");
        }else{
            Console.WriteLine("El producto del segundo con el tercer numero, es mayor a la suma de los dos primeros numeros.");
        }
        Console.WriteLine(" ");
        Console.WriteLine("---FIN DEL PROGRAMA---");
        
        }
    }
}