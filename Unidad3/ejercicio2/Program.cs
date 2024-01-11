using System;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
         //  int edad = 35;   

         //   if(edad > 30){
         //     Console.WriteLine("30 OFF");
         //  }else if(edad > 20){
         //     Console.WriteLine("21 OFF");
         //  }else if(edad == 18){
         //     Console.WriteLine("10 OFF");
         //  }else{
         //    Console.WriteLine("5 OFF");
         // }

         // Console.WriteLine("Fin del programa");        /Codigos con llaves.

           int edad = 18;

           if(edad > 30)
              Console.WriteLine("30 OFF");
           else if(edad > 20)             //else if => Sirve para poner otro segundo nivel de expresion condicional.
              Console.WriteLine("21 OFF");
           else if(edad == 18)
              Console.WriteLine("10 OFF");
           else
              Console.WriteLine("5 OFF");
           

           Console.WriteLine("Fin del programa");

        }
    }
}