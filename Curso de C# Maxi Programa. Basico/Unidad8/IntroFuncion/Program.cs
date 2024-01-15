using System;

namespace IntroFuncion
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // Aqui va el codigo.
        // Funciones.
        // Partes de la función.    
        // Cabecera.
        // 1. Tipo de datos.
        // 2. Nombre.
        // 3. Opcional: parametros.
        // Cuerpo.
        // Definicion / Logica.
        // Opcional: retorno de valores / Resultados.
        // int n =  devolverUno();

        Console.WriteLine("Fin del programa: " + devolverUno()); // asi se llama a la funcion.

        }

        static int devolverUno(){  // Funcion para a llamar. Siempre fuera de la funcion principal Main, fuera de sus llaaves del programa.
            int numero = 500;
            return numero;
        }
    }
}