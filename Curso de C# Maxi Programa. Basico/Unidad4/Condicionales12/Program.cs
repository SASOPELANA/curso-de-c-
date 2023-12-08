using System;

namespace Condicionales12
{
    class Program
    {
        static void Main(string[] args)
        {
        // 2. Un importante negocio de desinfectante líquido 
        //    realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
        // * Si vende menos de 100 litros, no hay descuento.
        // * Si vende entre 101 y 300 litros, el descuento es del 10%.
        // * Si vende entre 301 y 500 litros, el descuento es del 15%.
        // * Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
        //    Hacer un programa que solicite el ingreso del importe total de la venta
        //    y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..
        
        float litro, importe = 0;

        Console.WriteLine("Ingrese el importe de la venta:");
        importe = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los litros vendidos:");
        litro = float.Parse(Console.ReadLine());

        if(litro >= 101 && litro <= 300){
            importe = importe - (importe * 0.10f);
            Console.WriteLine("Tiene un descuento del 10%, su importe a pagar es: " + importe);
        }else if(litro >= 301 && litro <= 500){
            importe = importe - (importe * 0.15f);
            Console.WriteLine("Tiene un descuento del 15%, su importe a pagar es: " + importe);
        }else if(litro > 500){
            importe = importe - (importe * 0.25f);
            Console.WriteLine("Tiene un descuento del 25%, su importe a pagar es: " + importe);
        }else{
            importe = importe;
            Console.WriteLine("No tiene descuento, su importe a pagar es: " + importe);
        }
            Console.WriteLine("Fin del programa");
        }
    }
}
