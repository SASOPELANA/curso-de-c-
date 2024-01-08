using System;

namespace CortedeControl 

{
    class Program
    {
        static void Main(string[] args)
        {
        // Corte de Control.
        // legajo, edad, sueldo, codigo equipo, (numerico entre 1 y 50)
        int legajo, edad, codigoEquipo;
        float sueldo;
        int equipoActual;

        // Codigo de equipo
        // 1 Boca
        // 2 River
        // 3 Pizarro

        Console.WriteLine("Ingrese el legajo:");
        legajo = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el edad:");
        edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el sueldo:");
        sueldo = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el codigo de equipo:");
        codigoEquipo = int.Parse(Console.ReadLine());

        while (sueldo > 0)
        {
            equipoActual =  codigoEquipo;    // La asignacion para que sea un corte de control. "Importante"
            while (codigoEquipo == equipoActual)
            {
                // Aqui procesamos....

               Console.WriteLine("Ingrese el legajo:");
               legajo = int.Parse(Console.ReadLine());
               Console.WriteLine("Ingrese el edad:");
               edad = int.Parse(Console.ReadLine());
               Console.WriteLine("Ingrese el sueldo:");
               sueldo = float.Parse(Console.ReadLine());
               Console.WriteLine("Ingrese el codigo de equipo:");
               codigoEquipo = int.Parse(Console.ReadLine()); 

               // Aqui tambien se puede mostrar resultados......    
            }
            // Aqui mostramos lo que se necesite mostrar.....
        }
        // Aqui tambien se puede mostrar resultados.......

        }
    }
}