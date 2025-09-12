namespace _2._4_Listas_enlazadas___240085_polinomios
{
    using System;

    class Nodo
    {
        // Nodo de la lista enlazada para representar un término del polinomio
        public int Coeficiente; // Almacena el coeficiente del término
        public int Exponente;   // Almacena el exponente del término
        public Nodo siguiente;  // Apuntador al siguiente nodo de la lista
    }

    // Definición de la lista enlazada para almacenar el polinomio
    class Lista
    {
        public Nodo inicio; // Cabeza de la lista

        public Lista() { inicio = null; }

        // Método para insertar un término al final de la lista (similar a un ArrayList)
        public void InsertarF(int coef, int exp)
        {
            Nodo aux = new Nodo(); // Nodo temporal, todavía no pertenece a la lista
            aux.Coeficiente = coef; // Se almacena el coeficiente
            aux.Exponente = exp;     // Se almacena el exponente
            aux.siguiente = null;    // El nodo apunta inicialmente a null

            if (inicio == null)
            {
                inicio = aux; // Si la lista está vacía, el nodo se convierte en la cabeza
            }
            else
            {
                Nodo puntero = inicio; // Se usa para recorrer la lista sin mover la cabeza
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; // Se desplaza hasta el último nodo
                }
                puntero.siguiente = aux; // El último nodo enlaza con el nuevo nodo
            }
        }

        // Método para mostrar la lista de términos del polinomio
        public void Mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("LISTA VACÍA.");
            }
            else
            {
                Nodo puntero = inicio; // Se empieza el recorrido desde la cabeza
                while (puntero != null)
                {
                    Console.Write($"{puntero.Coeficiente}x^{puntero.Exponente} ");
                    if (puntero.siguiente != null) Console.Write("+ "); // Separador de términos
                    puntero = puntero.siguiente; // Se avanza al siguiente nodo
                }
                Console.WriteLine();
            }
        }

        // Método para calcular la derivada del polinomio
        public Lista Derivar()
        {
            Lista derivada = new Lista();
            Nodo actual = inicio;

            while (actual != null)
            {
                if (actual.Exponente > 0) // Solo se derivan términos con exponente mayor a 0
                {
                    // Se aplica la regla de derivación: n*x^(n-1)
                    derivada.InsertarF(actual.Coeficiente * actual.Exponente, actual.Exponente - 1);
                }
                actual = actual.siguiente; // Se avanza al siguiente nodo
            }

            return derivada; // Se retorna la lista con la derivada
        }

        // Método para evaluar el polinomio en un valor dado de x
        public double Evaluar(double x)
        {
            double resultado = 0;
            Nodo actual = inicio;

            while (actual != null)
            {
                resultado += actual.Coeficiente * Math.Pow(x, actual.Exponente); // Se calcula cada término
                actual = actual.siguiente; // Se avanza al siguiente nodo
            }

            return resultado; // Se retorna el resultado final
        }
    }

    class Program
    {
        static void Main()
        {
            Lista poli = new Lista();
            Console.WriteLine("     *****     BIENVENIDO A SISTEMA DE DERIVACIÓN DE POLINOMIOS     *****");

            while (true)
            {
                Console.WriteLine("\n          Ingrese los términos del polinomio (coeficiente, exponente):");
                Console.WriteLine("          Ejemplo: '3,4' para 3x^4. Presione Enter sin escribir nada para terminar.");
                string entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada)) // Si el usuario solo presiona Enter, termina la entrada
                    break;

                string[] valores = entrada.Split(','); // Separa el coeficiente y el exponente por coma
                if (valores.Length == 2 && int.TryParse(valores[0], out int coef) && int.TryParse(valores[1], out int exp))
                {
                    poli.InsertarF(coef, exp); // Agrega el término a la lista
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Intente nuevamente.");
                }
            }

            Console.WriteLine("\nPolinomio ingresado:");
            poli.Mostrar(); // Muestra el polinomio en formato correcto

            Console.Write("\nIngrese un valor para x: ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine($"Resultado de la evaluación: {poli.Evaluar(x)}");
            }
            else
            {
                Console.WriteLine("Entrada inválida para x.");
            }

            Console.WriteLine("\nDerivada del polinomio:");
            Lista derivada = poli.Derivar(); // Calcula la derivada del polinomio
            derivada.Mostrar(); // Muestra la derivada en formato correcto
        }
    }
}
