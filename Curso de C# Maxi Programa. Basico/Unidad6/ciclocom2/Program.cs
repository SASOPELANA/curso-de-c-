using System;

namespace ciclocom2
{
    class Program
    {
        static void Main(string[] args)
        {
        // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
        // * El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        // * Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
        
        int n, contotal, conimpar, conordenado = 0, minimo, gmaximpar = 0;
        double maximpar = -1, porcentaje;
        bool bandera;

        for (int x = 0; x < 5; x++)
        {   
            contotal = 0;
            conimpar = 0;
            bandera = true;
            Console.WriteLine("grupo: " + x + " . Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            minimo = n;
            while (n != 0)
            {
                contotal++;
                if (n % 2 != 0)
                {
                    conimpar++;
                }
                if (n <= minimo)
                {
                    minimo = n;
                }
                else 
                {
                    bandera = false;
                }
                Console.WriteLine("Ingrese un numero o cero (0) para terminar: ");
                n = int.Parse(Console.ReadLine());
            }
            porcentaje = conimpar * 100 / contotal;
            if (porcentaje > maximpar)
            {
               maximpar = porcentaje;   
               gmaximpar = x + 1; 
            }
            if (bandera)
            {
                conordenado++;
            }
        }
        
        Console.WriteLine("El grupo con mayor porcentaje de impares es: " + gmaximpar);
        Console.WriteLine("La cantidad de grupos con numeros ordenados es: " + conordenado);
        }
    }
}