using System;

namespace cadenaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
        // Cadena de caracteres.

        /*
        char[] frase = new char[10];
        char s = '\0';

        frase[5] = s;
        Console.WriteLine(frase[5]);
        */
        
        // String
        // Cadena de caracteres.
        // Vector char.

        // Caracter especial, Barra cero. 
        // \0

        // int, float, bool, char,   string -> no por ahora
        
        
        /*char[] nombre = new char[11]; // esto para que corte el programaa, por que \0 ocupa un indice. es [11] no [10]
        char letra;
        int indice = 0;
      
        Console.WriteLine("Ingrese su nombre por letras (o termina con punto) "); // forma mas precisa de ingresar nombres
        letra = char.Parse(Console.ReadLine()); // forma de cargar los char.
        while (letra != '.' && indice < 10)
        {
            nombre[indice] = letra; 
            letra = char.Parse(Console.ReadLine());
            indice++;      
        }
        nombre[indice] = '\0'; // manipulacion manual, cadena de caracteres. Condicion \0
        //  | s  | o | p | e | \0 |    |    |    |    |   |    

        Console.Write("Hola ");
        indice = 0; 
        while (nombre[indice] != '\0')
        {
            Console.Write(nombre[indice]);
            indice++;
        }*/
        
    
        string nombre;
        Console.WriteLine("Ingrese su nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine("hola " + nombre);
        

        }
    }
}