using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si 
        // el número es primo o cero si no lo es. Hacer un programa para ingresar números. 
        // El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
       
        int num, con = 0;
        double promedio = 0, acu = 0;

        Console.WriteLine("Ingrese numeros:");
        num = int.Parse(Console.ReadLine());

        while (num != 0)
        {
            bool b = primo(num);
            if (b)    // if (primo(num))  tambien sirve asi.          
            {
               con++;
               acu += num; 
            }
            Console.WriteLine("Ingrese numeros o cero (0) para terminar:");
            num = int.Parse(Console.ReadLine());
        }
        
        promedio = acu / con;

        Console.WriteLine("El promedio de los numeros primos es: " + promedio);

        }

        static bool primo(int a)
        {
            int con = 0;
            for (int x = 1; x <= a; x++)
            {
                if (a % x == 0)
                {
                    con++;
                }
            }
            if (con == 2)
                return true;
            else
                return false;
            
        }
    }
}