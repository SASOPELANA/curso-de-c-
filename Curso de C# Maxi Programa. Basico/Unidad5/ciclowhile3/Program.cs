using System;

namespace ciclowhile3
{
    class Program
    {
        static void Main(string[] args)
        {
        // Hacer en Ciclo While.  
        // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.  
        
        int edad, x = 0, acu = 0, con = 0, promedio;

        while (x < 20)
        {
           Console.WriteLine("Ingrese las edades: ");
           edad = int.Parse(Console.ReadLine());
           if (edad > 18)
           {
            con++;
            acu+=edad;  
           }
           x++;
        }
        promedio = acu / con;
        Console.WriteLine("El promedio de los mayores a 18 años es: " + promedio);
        }
    }
}