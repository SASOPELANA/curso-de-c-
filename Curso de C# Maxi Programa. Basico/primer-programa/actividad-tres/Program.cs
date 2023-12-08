using System;

namespace actividad_tres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
            // Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

            float velocidad, kilometros, tiempo;
           

            Console.WriteLine("Ingrese los kilometros existentes: ");
            kilometros = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese a la velocodad que viaja: ");
            velocidad = float.Parse(Console.ReadLine());

            tiempo = kilometros / velocidad;

            Console.WriteLine("El tiempo aproximado de llegar de un punto a otro es: " + tiempo.ToString("0.00") + " horas..");

            // tiempo.ToString("0.00")    sirve para mostrar dos digitos de un decimal
            














        }
    }
}
