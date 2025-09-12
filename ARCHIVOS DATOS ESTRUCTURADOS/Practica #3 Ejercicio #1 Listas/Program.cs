using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Practica__3_Ejercicio__1_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            bool vicente = true;
            string masLargo = "";
            while (vicente==true)
            {
                Console.WriteLine("     **********BITACORA DE REGISTRO DE CIUDADES ACTUALIZADAS**********");
                Console.WriteLine("               1.AGREGAR UNA NUEVA CIUDAD");
                Console.WriteLine("               2.ELIMINAR UNA CIUDAD");
                Console.WriteLine("               3.MOSTRAR CIUDAD(ES) CON EL NOMBRE MAS LARGO ");
                Console.WriteLine("               4.ELIMINAR LAS CIUDADES CON MENOS DE 6 CARACTERES");
                Console.WriteLine("               5.MOSTRAR TODAS LAS CIUDADES DE LA LISTA");
                Console.WriteLine("               6.BUSCAR UNA CIUDAD DENTRO DE LA LISTA");
                Console.WriteLine("               7.INVERTIR LISTA");
                Console.WriteLine("               8.SALIR");
                string aaa = Console.ReadLine();
                

                if (int.TryParse(aaa, out int selec))
                {
                    switch (selec)
                    {
                        default: Console.WriteLine("ERROR"); break;
                        case 1:
                            Console.WriteLine("AGREGAR CIUDAD: ");
                            string c1 = Console.ReadLine();
                            string c2 = c1.ToUpper();
                            nombres.Add(c2);
                            Console.WriteLine($"      {c2} AÑADIDO A LA LISTA.");
                            break;
                        case 2:
                            int i = 1;
                            if (nombres.Count == 0) { Console.WriteLine("LA LISTA ESTA VACIA."); }
                            else
                            {
                                foreach (string nombre in nombres)
                                {
                                    Console.WriteLine($"{i}.{nombre}");
                                    i++;
                                }
                                Console.Write("\nINGRESE EL NÚMERO DE LA CIUDAD A ELIMINAR (0 PARA SALIR): ");
                                if (int.TryParse(Console.ReadLine(), out int opcion))
                                {
                                    if (opcion == 0) { break; }
                                    else if (opcion >= 1 && opcion <= nombres.Count)
                                    {
                                        Console.WriteLine($"\n'{nombres[opcion - 1]}' HA SIDO REMOVID@ DE LA LISTA");
                                        nombres.RemoveAt(opcion - 1);
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERROR INTENTELO DE NUEVO.");
                                    }
                                }
                            }
                            break;
                        case 3:
                            if (nombres.Count == 0) { Console.WriteLine("LA LISTA ESTA VACIA."); }
                            else
                            {
                                foreach (string nombre in nombres) { if (nombre.Length > masLargo.Length) { masLargo = nombre; } }
                                Console.WriteLine("LAS CIUDADES CON EL NOMBRE MAS LARGO ES/SON: ");
                                foreach (string nombre in nombres) { if (nombre.Length == masLargo.Length) { Console.WriteLine(nombre); } }
                            }
                            break;
                        case 4:
                            
                            List<string> ciudadesParaEliminar = new List<string>();
                            if (nombres.Count == 0) { Console.WriteLine("LA LISTA ESTA VACIA."); }
                            else
                            {
                                foreach (string nombre in nombres)
                                {
                                    if (nombre.Length < 6)
                                    {
                                        ciudadesParaEliminar.Add(nombre);
                                    }
                                }

                                foreach (var ciudad in ciudadesParaEliminar)
                                {
                                    nombres.Remove(ciudad);
                                }

                                Console.WriteLine("SE REMOVIERON CIUDADES DE MENOS DE 6 LETRAS.");
                            }
                            break;
                        case 5:
                            if (nombres.Count == 0) { Console.WriteLine("LA LISTA ESTA VACIA."); }
                            else
                            {
                                i = 1;
                                Console.WriteLine("CIUDADES REGISTRADAS: ");
                                foreach (string nombre in nombres)
                                {
                                    Console.WriteLine($"{i}.{nombre}");
                                    i++;
                                }
                            }
                            break;
                        case 6: Console.WriteLine("INGRESE UN NOMBRE PARA BUSCAR: "); string bbb = Console.ReadLine();
                            string bb = bbb.ToUpper();
                            if (nombres.Contains(bb)) { Console.WriteLine("SE ENCUENTRA EN LA LISTA."); }
                            else { Console.WriteLine("EL NOMBRE NO SE ENCUENTRA EN LA LISTA."); }
                            break;
                        case 7:
                            if (nombres.Count == 0) { Console.WriteLine("LA LISTA ESTA VACIA."); }
                            else
                            {
                                i = 1;
                                nombres.Reverse();
                                Console.WriteLine("LAS CIUDADES EN ORDEN INVERTIDO SON: ");
                                foreach (string nombre in nombres)
                                {
                                    Console.WriteLine($"{i}.{nombre}");
                                    i++;
                                }
                            }
                            break;
                            case 8: Console.WriteLine("CERRANDO PROGRAMA, BUEN DIA.");vicente = false; break;

                    } 
                } else { Console.WriteLine("\nENTRADA INVALIDA. INGRESE UN NUMERO LISTADO."); }
            }
        }
    }
}
