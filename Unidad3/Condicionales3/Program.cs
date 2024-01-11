using System;

namespace Condicionales3;

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
		
		float i, it = 0;
		
		Console.WriteLine("Ingrese el importe de la compra");
		i = float.Parse(Console.ReadLine());
		
		if(i < 1000){
			Console.WriteLine("No hay descuento, el importe final es: " + i);
		}else if(i >= 5000){
			it = i - (i * 0.18f);
			Console.WriteLine("Descuento del 18 %, el importe final es: " + it);
		}else{
		    it = i - (i * 0.10f);
		    Console.WriteLine("Descuento del 10 %, el importe final es: "+ it);
		}		

	}
}
		