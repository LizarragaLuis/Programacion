namespace Practica__2_Ejercicio_1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Queue<string> q = new Queue<string>();
            int r = 0;
            bool asdads = true;

            while (asdads)
            {
                Console.WriteLine("");
                Console.WriteLine("====SISTEMA DE TURNOS====");
                Console.WriteLine("1. AGREGAR CLIENTE A LA COLA");
                Console.WriteLine("2. ATENDER CLIENTE ");
                Console.WriteLine("3. MOSTRAR CLIENTE/S EN ESPERA");
                Console.WriteLine("4. SALIR");
                Console.WriteLine("ESCOJA UNA OPCION: ");

                string input = Console.ReadLine();
                
          
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("INGRESE UNA OPCION VALIDA.");
                    continue; 
                }

                // ESTO REVISA SI SIRVE O NO SIRVE 
                if (!int.TryParse(input, out r))
                {
                    Console.WriteLine("INGRESE UN NUMERO.");
                    continue; 
                }

                
                switch (r)
                {
                    case 1:
                        Console.WriteLine("INGRESE UN NOMBRE:");
                        string cliente = Console.ReadLine();
                        //REVISA POR ERRORES
                        if (string.IsNullOrEmpty(cliente))
                        {
                            Console.WriteLine("INGRESE UN NOMBRE VALIDO.");
                           
                        }
                        else
                        {
                            q.Enqueue(cliente);  
                            Console.WriteLine($"CLIENTE {cliente} AGREGADO A LA COLA.");

                        }
                        break;
                    case 2:
                        if (q.Count > 0)
                        {
                            string atendido = q.Dequeue(); 
                            Console.WriteLine($"CLIENTE {atendido} ATENDIDO.");
                        }
                        else
                        {
                            Console.WriteLine("NO HAY GENTE EN LA LISTA DE ESPERA.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("CLIENTES EN LA LISTA DE ESPERA:");
                        foreach (var c in q)
                        {
                            Console.WriteLine(c);
                        }
                        break;
                    case 4:
                        asdads = false;
                        Console.WriteLine("CERRANDO EL PROGRAMA, BUEN DIA.");
                        
                        break;
                    default:
                        Console.WriteLine("OPCION NO VALIDA");
                        break;
                }
            }
        }
    }
}