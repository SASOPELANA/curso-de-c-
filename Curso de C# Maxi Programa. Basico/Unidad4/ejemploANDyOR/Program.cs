using System;

namespace ejemploANDyOR
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND y OR ....... NOT
            // AND [y] Operador: &&
            // OR [o] Operador: ||
            // valor OP valor OP valor OP valor
            // NOT [negacion] Operador: !

            int edad = 20;
            char inicial = 'j';
            
            
            // true    ||    false

            if(edad > 20 || inicial == 'H' && inicial == 'j'){
                 Console.WriteLine("21 OFF");
            }

            // Operador OR: ||
            // true || false = true
            // false || true = true
            // true || true = true
            // false || false = false

             
            // Operador AND: &&
            // true && true = true
            // false && true = false
            // true && false = false
            // false && false = false

            // Operador NOT; !
            // Sirve para negar una operacion logica.


        }
    }
}