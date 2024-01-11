using System;

namespace Condicionales1;

public static class Program
{
	public static void Main()
	{
     // 1. Hacer un programa para ingresar un numero y
     // luego se emita por pantalla un cartel aclaratorio
     // si "Es mayor a 10" o "No es mayor a 10".

     int n1;
     Console.WriteLine("Ingrese un numero aleatorio");
     n1 = int.Parse(Console.ReadLine());

     if(n1 > 10){
        Console.WriteLine( n1 + " Es mayor 10");
     }else{
        Console.WriteLine( n1 + " Es menor a 10");
     }
     Console.WriteLine("Fin del programa");

	}
} 

