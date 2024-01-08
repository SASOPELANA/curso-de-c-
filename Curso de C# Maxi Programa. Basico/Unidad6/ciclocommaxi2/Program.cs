using System;

namespace ciclocommaxi2
{
    class Program
    {
        static void Main(string[] args)
        {
        // 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. 
        // Se pide determinar e informar:
        // * El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        // * Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
        
        int n, conNumeros, conImpares, grupoImparesMaximo = 0, min, conOrdenados = 0;
        double porcentajeImpares, porcentajeMaximo = 0;
        bool banderaOrdenada;

        for (int x = 0; x < 5; x++)
        {
            conNumeros = 0;
            conImpares = 0;
            banderaOrdenada = true;
            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            min = n;

            while (n != 0)
            {
                conNumeros++;
                if(n % 2 != 0)
                   conImpares++;

                // Punto B.
                if(n <= min)
                    min = n;
                else
                    banderaOrdenada = false;

            Console.WriteLine("Igrese otro numero o cero (0), para finalizar:");
            n = int.Parse(Console.ReadLine());
            }// Fin del ciclo While.

            // Regla de 3 para porcentajes
            // conNumeros -> 100%
            // conImapres -> x=?

            porcentajeImpares = conImpares * 100 / conNumeros;
            if(porcentajeImpares > porcentajeMaximo){
               porcentajeMaximo = porcentajeImpares;
               grupoImparesMaximo = x + 1;
            }

            // Punto B.
            if(banderaOrdenada)
               conOrdenados++;

        }// Fin del ciclo For.
        
        Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoImparesMaximo);
        Console.WriteLine("La cantidad de grupos con numeros ordenados es: " + conOrdenados);

        }
    }
}