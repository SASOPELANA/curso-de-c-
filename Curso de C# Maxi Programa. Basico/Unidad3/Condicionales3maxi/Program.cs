using System;

namespace Condicionales3maxi
{
public static class Program
 {
	public static void Main()
	{
     // 3. Una casa de video juegos otorga un descuento dependiendo
	  // del importe de la compra realizada según los siguientes valores:
     // Si el importe es menor a ARS 1000, no hay descuento.
     // Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
     // Si el importe es ARS 5000 o más, aplica un descuento del 18%.
     // Hacer un programa para ingresar un importe de venta y luego muestre por pantalla 
	  // el importe final con el descuento que corresponda.

     float importe, importefinal = 0;

     Console.WriteLine("Ingrese el importe");
     importe = float.Parse(Console.ReadLine());

     if(importe >= 1000){
        // Tengo que calcular algo...
        if(importe > 5000)
           importefinal = importe * 0.82f;
        else
           importefinal = importe * 0.90f;           
     }else{
           importefinal = importe;
     }
     Console.WriteLine("El importe a cobrar es: " + importefinal);
   	}
   }
}