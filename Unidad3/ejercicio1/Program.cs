using System;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bloque If: Condicionales.
            // > < >= <= == !=
            // valor op valor
            // n1 > 10
            // 10 > 5     ESTO NO

            int edad = 35;

            if(edad > 21){
                if(edad > 30)
                Console.WriteLine("30 OFF");   
                else
                Console.WriteLine("21 OFF");                         
            }else
                Console.WriteLine("10 OFF");
            

            Console.WriteLine("Fin del programa");

        }
    }
}