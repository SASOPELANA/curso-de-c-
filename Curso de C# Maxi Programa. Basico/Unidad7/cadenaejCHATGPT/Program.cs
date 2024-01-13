using System;

class Program
{
    static void Main()
    {
        // Declarar y asignar una cadena de caracteres en C#
        string miCadena = "Hola, mundo!";

        // Imprimir la cadena de caracteres
        Console.WriteLine(miCadena);

        // Concatenar cadenas
        string otraCadena = "¡Bienvenido a ";
        string resultado = otraCadena + miCadena;
        Console.WriteLine(resultado);

        // Obtener la longitud de la cadena
        int longitud = miCadena.Length;
        Console.WriteLine("Longitud de la cadena: " + longitud);

        // Acceder a caracteres individuales
        char primerCaracter = miCadena[0];
        Console.WriteLine("Primer carácter: " + primerCaracter);

        // Comparar cadenas
        string otraCadena2 = "Hola, mundo!";
        bool sonIguales = miCadena == otraCadena2;
        Console.WriteLine("¿Son iguales? " + sonIguales);
    }
}
