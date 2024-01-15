using System;

namespace VEC3MAXI
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
        // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. 
        // Mostrar el resultado en pantalla. Ejemplo:
        // CADENA FUENTE: “La mar estaba serena"
        // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        // CADENA RESULTADO: “Li mir estibi sereni"
        

        // Metodo Gigachad............
        
        /*
        char[] frase = new char[30];

        char letraActual;
        char letraNueva;
        int indice = 0;
        
        char letra;
        Console.WriteLine("Ingrese la letra para la frase: ");
        letra = char.Parse(Console.ReadLine());
        while (letra != '0' && indice < 30)
        {
            frase[indice] = letra;
            Console.WriteLine("Ingrese la letra para la frase o cero (0) para salir: ");
            letra = char.Parse(Console.ReadLine());
            indice++;   
        }
        frase[indice] = '\0'; // INDICA EL FINAL DE UNA CADENA -->  \0
        
        Console.WriteLine("La frase completa es:");
        indice = 0;
        while (frase[indice] != '\0')
        {
            Console.Write(frase[indice]);
            indice++;
        }

        Console.WriteLine("  ");

        Console.WriteLine("Ingrse la letra a remplazar: ");
        letraActual = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrse la letra nueva: ");
        letraNueva = char.Parse(Console.ReadLine()); 

        indice = 0;
        while (frase[indice] != '\0')
        {
            if (frase[indice] == letraActual)
            frase[indice] = letraNueva;
            indice++;
        } 

        indice = 0;
        Console.WriteLine("La nueva frase es: ");
        while (frase[indice] != '\0')
        {
            Console.Write(frase[indice]);
            indice++;

        }

        Console.WriteLine(" ");
        */

        // METODO MAS DINAMICO Y ACTUAL.

        
        string frase;
        char letraActual;
        char letraNueva;
        Console.WriteLine("Ingrese la frase: ");
        frase = Console.ReadLine();
        Console.WriteLine("Ingrese la letra a remplazar: ");
        letraActual = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la letra nueva: ");
        letraNueva = char.Parse(Console.ReadLine());

        frase = frase.Replace(letraActual, letraNueva);

        Console.WriteLine("La frase nueva es:");
        Console.WriteLine(frase);
        

        }
    }
}