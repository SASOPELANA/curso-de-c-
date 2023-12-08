using System;

namespace Condicionales13
{
    class Program
    {
        static void Main(string[] args)
        {
        
        // 3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
        // Para ello existe la siguiente escala de precios:

        //              i5 (1)	     i7 (2)	           i9 (3)
        // 8 RAM (1)   USD 800	    USD 900	          USD 1200     
        // 16 RAM (2)  USD 900	    USD 1000	          USD 1400            
        // 32 RAM (3)  USD 1000	    USD 1400	          USD 2000

        // Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede 
        // ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa 
        // que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no 
        // (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la 
        // máquina seleccionada.
        
        int opcionesprocesador, opcioanesram;
        float montofinal = 0, final = 0;
        
        Console.WriteLine("Ingrese la opcion del procesador:");
        opcionesprocesador = int.Parse(Console.ReadLine());
        Console.WriteLine("Eliga la opcion de memoria ram:");
        opcioanesram = int.Parse(Console.ReadLine());

        switch (opcionesprocesador){
               
               case 1:
                      Console.WriteLine("Usted elegio un procesador Intel core i5.");
                      switch (opcioanesram){
                             
                             case 1:
                                      Console.WriteLine("Escogio 8 GB de memoria ram, con un valor de USD 800.");
                                      montofinal = 800;
                                      break;
                             case 2:
                                      Console.WriteLine("Escogio 16 GB de memoria ram, con un valor de USD 900.");
                                      montofinal = 900;
                                      break;
                             case 3:
                                      Console.WriteLine("Escogio 32 GB de memoria ram, con un valor de USD 1000."); 
                                      montofinal = 1000;
                                      break; 
                               default:
                                     Console.WriteLine("Opcion de memoria ram no valida."); 
                                     Console.WriteLine(" ");
                                     Console.WriteLine("--FIN DEL PROGRAMA--");
                                     return;  
                                                       
                      }

                    break;

               case 2:
                       Console.WriteLine("Usted elegio un procesador Intel core i7.");
                       switch (opcioanesram){
                             
                             case 1:
                                      Console.WriteLine("Escogio 8 GB de memoria ram, con un valor de USD 900.");
                                      montofinal = 900;
                                      break;
                             case 2:
                                      Console.WriteLine("Escogio 16 GB de memoria ram, con un valor de USD 1000. ");
                                      montofinal = 1000;
                                      break;
                             case 3:
                                      Console.WriteLine("Escogio 32 GB de memoria ram, con un valor de USD 1400."); 
                                      montofinal = 1400;
                                      break;  
                              default:
                                     Console.WriteLine("Opcion de memoria ram no valida."); 
                                     Console.WriteLine(" ");
                                     Console.WriteLine("--FIN DEL PROGRAMA--");
                                     return;   
                                                    
                      }

                    break;

               case 3:
                      Console.WriteLine("Usted elgio un procesador Intel core i9.");
                       switch (opcioanesram){
                             
                             case 1:
                                      Console.WriteLine("Escogio 8 GB de memoria ram, con un valor de USD 1200.");
                                      montofinal = 1200;
                                      break;
                             case 2:
                                      Console.WriteLine("Escogio 16 GB de memoria ram, con un valor de USD 1400.");
                                      montofinal = 1400;
                                      break;
                             case 3:
                                      Console.WriteLine("Escogio 32 GB de memoria ram, con un valor de USD 2000."); 
                                      montofinal = 2000;
                                      break;
                             default:
                                     Console.WriteLine("Opcion de memoria ram no valida.");  
                                     Console.WriteLine(" ");
                                     Console.WriteLine("--FIN DEL PROGRAMA--");
                                     return;             
                      }

                break; 

                default:
                       Console.WriteLine("Opcion de procedaor no valida.");
                       Console.WriteLine(" ");
                       Console.WriteLine("--FIN DEL PROGRAMA--");
                return;      

        }  

        Console.WriteLine(" ");
        Console.WriteLine("Agregar un 1TB de almacenamiento. Uno (1) para confirmar, cero (0) para no agregar");
        final = float.Parse(Console.ReadLine());

        if(final == 1){
            montofinal = montofinal + 300;
        }
        
        Console.WriteLine("Su monto final a pagar es: USD " + montofinal);
        Console.WriteLine(" ");
        Console.WriteLine("--FIN DEL PROGRAMA--");

        }
    }
}