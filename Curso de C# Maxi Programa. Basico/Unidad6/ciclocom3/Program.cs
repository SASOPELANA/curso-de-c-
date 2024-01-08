using System;

namespace ciclocom3
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
        // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

        int n = 1, con;

        while (n >= 0)
        {

            con = 0;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            while ( n != 0 && n > 0)
            {
               
                con++;
                Console.WriteLine("Ingrese un numero o un numero negativo para terminar: ");
                n = int.Parse(Console.ReadLine());
            }

          Console.WriteLine("la lista tiene  " + con + " numeros.");  
        }

        }
    }
}