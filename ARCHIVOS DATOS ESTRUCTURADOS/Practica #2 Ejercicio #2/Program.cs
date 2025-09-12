using System.Runtime.ConstrainedExecution;

namespace Practica__2_Ejercicio__2
{
    internal class Program
    {
            static void Main(string[] args)
            {
            // Desarrollar un programa en C# que simule el funcionamiento de una cola de impresión
            // utilizando una cola circular con un máximo de 5 trabajos.
            int r = 0;
                int i = 1; // Contador de documentos
                bool continuar = true;
                int size = 5;
                int inicio = -1, fin = -1;
                int[] cola = new int[size];

                while (continuar)
                {
                    Console.WriteLine("\n     ***** PAPELERÍA CHUYITA ******");
                    Console.WriteLine("     1. AGREGAR DOCUMENTO A LA LISTA DE ESPERA");
                    Console.WriteLine("     2. IMPRIMIR DOCUMENTO");
                    Console.WriteLine("     3. SALIR");
                    Console.Write("     ESCOJA UNA OPCION:   ");

                    // LE PICARON ESPACIO?
                    if (!int.TryParse(Console.ReadLine(), out int opcion))
                    {
                        Console.WriteLine("     ERROR INTENTA DE NUEVO.");
                        continue;
                    }
                if (r == 4) { r = 0; Console.Clear(); } else { r++; }
                    switch (opcion)
                    {
                        case 1:
                            // COLA LLENA?
                            if ((fin + 1) % size == inicio)
                            {
                                Console.WriteLine("     COLA LLENA. NO SE PUEDEN AGREGAR MAS DOCUMENTOS.");
                            }
                            else
                            {
                                if (inicio == -1) inicio = 0; // COLA VACIA?
                                fin = (fin + 1) % size;
                                cola[fin] = i;
                                Console.WriteLine($"     DOCUMENTO {i} AGREGADO A LA COLA.");
                                i++;
                            }
                            break;

                        case 2:
                           
                            if (inicio == -1)
                            {
                                Console.WriteLine("     COLA VACÍA");
                            }
                            else
                            {
                                Console.WriteLine($"     DOCUMENTO {cola[inicio]} IMPRESO.");
                                if (inicio == fin)
                                {
                                
                                    inicio = -1;
                                    fin = -1;
                                }
                                else
                                {
                                    inicio = (inicio + 1) % size;
                                }
                            }
                            break;

                        case 3:
                            continuar = false;
                            Console.WriteLine("     CERRANDO PROGRAMA...");
                            break;

                        default:
                            Console.WriteLine("     ERROR. INTENTALO DE NUEVO.");
                            break;
                    }
                }
            }
        }
    }