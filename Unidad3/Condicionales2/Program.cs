using System;
using System.Linq;

namespace Condicionales2;

public static class Program
{
	public static void Main()
	{
        // 2. Hacer un programa para ingresar un numero y
        // luego se emita un cartel por pantalla "Positivo" si el numero es mayor a cero,
        // "Negativo" si el numero es menor a cero o "Cero" si el numero es igual a cero.

    int n1;  

    Console.WriteLine("Digite un numero");
    n1 = int.Parse(Console.ReadLine());

    if(n1 > 0){
        Console.WriteLine(n1 + " Es Positivo, por que es mayor a cero.");
    }else if(n1 < 0){
        Console.WriteLine(n1 + " Es Negativo, por que el numero es menor a cero.");
    }else
        Console.WriteLine(n1 + " Es cero, por que el numero es igual a cero.");
    
    Console.WriteLine("Fin del programa.");

	}
}