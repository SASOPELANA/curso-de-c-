using System;

namespace actividad_cuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
            // Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

            float facturado, comision, sueldototal;

            Console.WriteLine("Ingrese lo total facturado por el empleado");
            facturado = float.Parse(Console.ReadLine());

            comision = facturado * 0.05f; // Añadir 'f' al literal para indicar que es un float
            sueldototal = comision + 15000;

            Console.WriteLine("El sueldo total a cobrar del empleado es: " + sueldototal);









        
        
        }
    }
}
