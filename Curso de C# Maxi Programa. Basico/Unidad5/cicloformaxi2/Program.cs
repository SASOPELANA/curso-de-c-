using System;

namespace cicloformaxi2
{
    class Program
    {
        static void Main(string[] args)
        {

        // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
        // Solo se debe emitir UN valor por pantalla.

        int n, max = 0;

        for(int x = 0; x < 10; x++){
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            if(x == 0)   // Forma de sacar la maxima en numeros menores a cero (0), sin el error del que el maximo sea cero(0),
               max = n;  // con esto maxima cera -1.
            else{
                if(n > max)
                max = n;
            }
            
        }

        Console.WriteLine("El maximo es: " + max);

        }
    }
}