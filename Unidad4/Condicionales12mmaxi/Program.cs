using System;

namespace Condicionales12mmaxi
{
    class Program
    {
        static void Main(string[] args)
        {
        // 2. Un importante negocio de desinfectante líquido realiza descuentos 
        // dependiendo de la cantidad de litros vendidos según la siguiente escala:

        // Si vende menos de 100 litros, no hay descuento.
        // Si vende entre 101 y 300 litros, el descuento es del 10%.
        // Si vende entre 301 y 500 litros, el descuento es del 15%.
        // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

        // Hacer un programa que solicite el ingreso del importe total de la venta y 
        // la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado.
        
        float litros, importetotal = 0;

        Console.WriteLine("Ingrese el importe de la venta:");
        importetotal = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los litros:");
        litros = float.Parse(Console.ReadLine());

        //if(litros < 100){
        //   importefinal = importetotal;
        //}else if(litros > 100 && litros <= 300){
        //    importefinal = importetotal * 0.90f;         // condigo con tres variables.
        //}else if(litros > 300 && litros <= 500){         // float importetotal, litros, importefinal;
        //    importefinal = importetotal * 0.85f;
        //}else if(litros > 500){
        //    importefinal = importetotal * 0.75f;
        // }

        if(litros > 500)
           importetotal *= 0.75f;
        else if(litros > 300)
           importetotal *= 0.85f;
        else if(litros > 100)
           importetotal *= 0.90f;

        Console.WriteLine("El importe final a pagar es: " + importetotal);

        }
    }
}
