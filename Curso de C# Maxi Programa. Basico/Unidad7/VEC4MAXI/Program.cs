using System;

namespace VEC4MAXI
{
    class Program
    {
        static void Main(string[] args)
        {
        // 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        // - Número de Artículo (1 a 15)
        // - Cantidad Vendida 
        // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0. 
        // -----------------------------------------------------------------------------------------------------------------------------
        // Se pide determinar e informar:
        //     a) El número de artículo que más se vendió en total.
        //     b) Los números de artículos que no registraron ventas.
        //     c) Cuantas unidades se vendieron del número de artículo 10.

        int numeroArticulo;
        int cantidad;
        int[] totalCantidadVendida = new int[15]; // Acumulador, vector.
        
        for (int x = 0; x < 15; x++) // Metodo de ingrsar y cargar varios acumuladores.
        {
            totalCantidadVendida[x] = 0;
        }

        Console.WriteLine("Ingrese el numero de articulo: ");
        numeroArticulo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida: ");
        cantidad = int.Parse(Console.ReadLine());

        while (numeroArticulo != 0)
        {

            totalCantidadVendida[numeroArticulo - 1] += cantidad;

            Console.WriteLine("Ingrese el numero de articulo: ");
            numeroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());
        }
        
        // Puntp A:
        int maxCantidad = totalCantidadVendida[0];
        int numeroMaximo = 1;
        for (int x = 0; x < 15; x++)
        {
            if(totalCantidadVendida[x] > maxCantidad)
            {
                maxCantidad = totalCantidadVendida[x];
                numeroMaximo = x + 1; 
            }
        }
        Console.WriteLine("El numero de articulo que mas se vendio es el: " + numeroMaximo + " con la cantidad de: " + maxCantidad);

        // Punto B:
        for (int x = 0; x < 15; x++)
        {
            if (totalCantidadVendida[x] == 0)
            {
                Console.WriteLine("El producto que no tuvo ventas es: " + (x + 1));
            }
        }

        // Punto C:
        Console.WriteLine("La cantidad vendida unidades que se vendieron en el articulo 10 es: " + totalCantidadVendida[9]);

        }
    }
}