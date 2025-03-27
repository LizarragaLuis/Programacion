
namespace EJERCICIO_BUSQUEDA_EN_PROFUNDIDAD
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static Dictionary<char, List<char>> grafo = new Dictionary<char, List<char>>
        {
            {'A', new List<char>{ 'B', 'C', 'D' }},
            {'B', new List<char>{ 'E', 'F' }},
            {'C', new List<char>{ 'G' }},
            {'D', new List<char>{ 'H' }},
            {'E', new List<char>{ 'I', 'J' }},
            {'F', new List<char>{ 'K' }},
            {'G', new List<char>{ 'L' }},
            {'H', new List<char>{ 'M', 'N' }},
            {'L', new List<char>{ 'O' }},
            {'M', new List<char>{ 'O' }},
            {'N', new List<char>{}},
            {'O', new List<char>{}}
        };

        static HashSet<char> visitados = new HashSet<char>();

        static void profundidad(char nodo)
        {
            if (visitados.Contains(nodo)) return;  // NO REVISA NODOS VISTOS ANTERIORMENTE

            Console.Write(nodo + " "); // MUESTRA EL NODO VISITADO
            visitados.Add(nodo); // LO MARCA COMO VISITADO

            if (grafo.ContainsKey(nodo)) // VALIDACION EN CCASO QUE NO TENGA VECINOSS
            {
                foreach (char vecino in grafo[nodo])
                {
                    profundidad(vecino); // MANDAR A LLAMAR CADA VECINO
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("RECORRIDO EN PROFUNDIDAD, INGRESE UN NODO (A-O):");
            string respuesta = Console.ReadLine();

            // VALIDACION
            if (!string.IsNullOrEmpty(respuesta) && respuesta.Length == 1)
            {
                char nodoInicial = respuesta[0]; // CONVERSION STRING A CHAR

                if (grafo.ContainsKey(nodoInicial)) // EXISTE EL NODO?
                {
                    profundidad(nodoInicial); // LLAMAR LA RESPUESTA EN EL METODO
                }
                else
                {
                    Console.WriteLine("NO EXISTE EL NODO EN EL GRAFO.");
                }
            }
            else
            {
                Console.WriteLine("ERROR, INGRESE UN SOLO CARACTER.");
            }
        }

    }
}

