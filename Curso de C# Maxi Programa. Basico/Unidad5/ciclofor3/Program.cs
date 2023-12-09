using System;

namespace ciclofor3
{
    class Program
    {
        static void Main(string[] args)
        {
             
        //    3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.  
        
        int edad, acu = 0, con = 0; 
        float promedio;

        for (int x = 1; x <= 20; x++)
        { 
            Console.WriteLine(x + ". Ingrese 20 edades de personas: ");
            edad = int.Parse(Console.ReadLine());

        if (edad > 18)
        {
            acu += edad;
            con++;
        }  
        }
         
        if (acu != 0)
        {
           promedio =(float) acu / con; // forma para mostrar resulados con decimales.
           Console.WriteLine("El promedio de las personas mayores a 18 años es: " + promedio.ToString("0.00"));
        }
        else
        {
           Console.WriteLine("No hay personas mayores a 18 años.");        
        }

        }
    }
}