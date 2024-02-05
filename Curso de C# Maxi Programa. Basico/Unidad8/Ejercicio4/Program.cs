using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
        // que reciba un número por valor y una variable por referencia. Que analice el número y escriba 
        // variable recibida por referencia con:

        // a. 1 si el número es positivo.
        // b. -1 si el número es negativo.
        // c. 0 si el número es cero.

        int a, b = 10;
        Console.WriteLine("Ingrese un numero: ");
        a = int.Parse(Console.ReadLine());

        positivoNegativoCero(a, ref b);

        Console.WriteLine("El valor del numero " + a + " es: " + b);
       
        }

        static void positivoNegativoCero(int n1, ref int n2)
        {
            if (n1 > 1)
            {
                n2 = 1;
            }else if (n1 == 0)
            {
                n2 = 0;
            }else
            {
                n2 = -1;
            }

        }
    }
}