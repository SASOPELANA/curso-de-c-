using System;

namespace vecDouble
{
    class Program
    {
        static void Main(string[] args)
        {
        // Vectores Double
        // int (long, short)
        // float (double, decimal)

        /*
        double[] muestraMatutina = new double[31];
        double[] muestraVespertina = new double[31];
        double[] muestraNocturna = new double[31];

        // Cruce
        // Registro matutino.
        int dia;
        double temperatura;
        Console.Write("Ingrese el registro matutino: ");
        for (int x = 0; x < 31; x++)
        {
            Console.WriteLine("Ingrese el dia: ");// FORMA DE ALMACENAR DOS DATOS EN EL MISMO VECTOR.
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la temperatura registrada: ");
            temperatura = double.Parse(Console.ReadLine());

            muestraMatutina[dia-1] = temperatura; // Forma de crusar y ordenar los datos en el vector. Solo sirve con numeros consecutivos.


        }
        for (int x = 0; x < 31; x++)
        {
            
        }
        for (int x = 0; x < 31; x++)
        {
            
        }
        */

        double[] sueldos = new double[5];
        double[] legajos = new double[5];
        double sue, leg;
        Console.WriteLine("Ingrese sueldo y legajos; ");
        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Ingrese el sueldo: ");
            sue = double.Parse(Console.ReadLine());
            sueldos[x] = sue;
            Console.WriteLine("Ingrese el legajos: ");
            leg = double.Parse(Console.ReadLine());
            legajos[x] = leg;
        }

        for (int x = 0; x < 5; x++)
        {
            Console.WriteLine("Sueldos son: " + sueldos[x]);
            Console.WriteLine("Legajos son: " + legajos[x]);
        }

        }
    }
}