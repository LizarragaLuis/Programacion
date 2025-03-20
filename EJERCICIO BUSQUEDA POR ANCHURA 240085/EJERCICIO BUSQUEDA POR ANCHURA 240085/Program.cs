namespace EJERCICIO_BUSQUEDA_POR_ANCHURA_240085
{
    class nodo
    {
        public string Valor;
        public List<nodo> adyacente = new List<nodo>();
        public nodo(string valor)
        {
            Valor = valor;
        }

        class Busqueda
        {
            public static void BFS(nodo inicio)
            {
                Queue<nodo> cola = new Queue<nodo>();
                HashSet<nodo> visitados = new HashSet<nodo>(); //LISTA DE NODOS
                Dictionary<nodo, nodo> padres = new Dictionary<nodo, nodo>(); // DONDE SE GUARDARA E IMPRIMIRA LA COORDENADA

                cola.Enqueue(inicio);
                visitados.Add(inicio);
                padres[inicio] = null;

                while (cola.Count > 0)
                {
                    nodo nodoActual = cola.Dequeue();

                    if (padres[nodoActual] != null)
                    {
                        Console.WriteLine($"Visitando intersección: {nodoActual.Valor} desde intersección {padres[nodoActual].Valor}");
                    }
                    else
                    {
                        Console.WriteLine($"Visitando intersección: {nodoActual.Valor} (nodo inicial)");
                    }

                    foreach (nodo vecino in nodoActual.adyacente)
                    {
                        if (!visitados.Contains(vecino))
                        {
                            cola.Enqueue(vecino);
                            visitados.Add(vecino);
                            padres[vecino] = nodoActual;
                        }
                    }
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // CREACION DE NODOS Y ASIGNADOS DE ADYACENTES
                nodo A = new nodo("A");
                nodo B = new nodo("B");
                nodo C = new nodo("C");
                nodo D = new nodo("D");
                nodo E = new nodo("E");
                nodo F = new nodo("F");
                nodo G = new nodo("G");
                nodo H = new nodo("H");
                nodo I = new nodo("I");
                nodo J = new nodo("J");
                nodo K = new nodo("K");

                
                A.adyacente.Add(B);
                B.adyacente.Add(A); B.adyacente.Add(F); B.adyacente.Add(C);
                C.adyacente.Add(B);
                D.adyacente.Add(E);
                E.adyacente.Add(D); E.adyacente.Add(F); E.adyacente.Add(I);
                F.adyacente.Add(B); F.adyacente.Add(E);
                G.adyacente.Add(F); G.adyacente.Add(K);
                H.adyacente.Add(I);
                I.adyacente.Add(H); I.adyacente.Add(E); I.adyacente.Add(J);
                J.adyacente.Add(I); J.adyacente.Add(K);
                K.adyacente.Add(G); K.adyacente.Add(J);

                // EL GRAFO (LISTA DE NODOS)
                List<nodo> grafo = new List<nodo> { A, B, C, D, E, F, G, H, I, J, K };
//USUARIO INGRESA VALOR INICIAL
                Console.WriteLine("INGRESE UN CRUCE DE CALLE (ETIQUETADOS DE A HASTA K):");
                string comando = Console.ReadLine().ToUpper();

                // VALIODACION
                if (comando.Length == 1 && comando[0] >= 'A' && comando[0] <= 'K')
                {
                    // SE BUSCA EL NODO EN LA LISTA
                    nodo inicio = grafo.Find(n => n.Valor == comando);

                    if (inicio != null)
                    {
                        
                        Busqueda.BFS(inicio);
                    }
                    else
                    {
                        Console.WriteLine("Nodo no encontrado en el grafo.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Debes ingresar una única letra de A a K.");
                }
            }
        }
    }
}



