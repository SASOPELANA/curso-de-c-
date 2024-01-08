using System;

namespace ciclocomej1
{
    class Program
    {
        static void Main(string[] args)
        {
        // Ciclo combinados.

        // For con For.
        // int prom, n, acu;

        // for (int i = 0; i < 10; i++)
        // {   
        //     acu = 0;
        //    for (int x = 0; x < 20; x++)
        // {
        //    Console.WriteLine("Ingrese la edad");
        //    n = int.Parse(Console.ReadLine());   
        //    acu += n;
        // }
        // prom = acu / 20;
        // Console.WriteLine("El promedio es: " + prom);
        // }
        
        // -------------------------------------------------------------------------------------
        // Ciclo For con While.
        // int prom, n, acu, con;

        // acu = 0;
        // con = 0;

        // for (int x = 0; x < 10; x++)
        // {

        // Console.WriteLine("Ingrese la edad:");
        // n = int.Parse(Console.ReadLine()); 
        // while (n != 0)
        // {  
        //     acu += n;
        //     con++;
        //     Console.WriteLine("Ingrese la edad:");
        //     n = int.Parse(Console.ReadLine()); 
        // }
        // prom = acu / con;
        // Console.WriteLine("El promedio es: " + prom);
        // }
        // -----------------------------------------------------------------------
        
        // Ciclo While con For.
        // int prom, n, acu, con;

        // Console.WriteLine("Ingrese 1 para procesar o 0 para terminar.");
        // n = int.Parse(Console.ReadLine());   
        // while (n != 0)
        // {
        //     acu = 0;
        //     for (int x = 0; x < 20; x++)
        //     {
        //     Console.WriteLine("Ingrese la edad");
        //     n = int.Parse(Console.ReadLine());   
        //     acu += n;
        //     }
        //     prom = acu / 20;
        //     Console.WriteLine("El promedio es: " + prom);

        //    Console.WriteLine("Ingrese 1 para procesar o 0 para terminar.");
        //    n = int.Parse(Console.ReadLine());   
        // }

        // ---------------------------------------------------------------------------
        // Ciclo While con While.
        
        int prom, n, acu, con;

        Console.WriteLine("Ingrese la edad:");
        n = int.Parse(Console.ReadLine()); 

        while (n > 0)  // Si ingresa un cero (0) que corte el ciclo. Motivos dara error......
        {
            acu = 0;
            con = 0;
            while (n != 0)
           {  
            acu += n;
            con++;
            Console.WriteLine("Ingrese la edad:");
            n = int.Parse(Console.ReadLine()); 
            }
            prom = acu / con;
            Console.WriteLine("El promedio es: " + prom);

            Console.WriteLine("Ingrese la edad para continuar o un negativo para cortar:");
            n = int.Parse(Console.ReadLine()); 
        
        }
        Console.WriteLine("--FIN DEL PROGRAMA--");  
        }
    }
}