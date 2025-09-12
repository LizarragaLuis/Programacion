namespace Tarea_2._5_Practica_Doble_ligado__240085
{
    class nodo
    {
        public char dato; //atributo "cadena" que almacena el valor del nodo
        public nodo anterior; //señala al nodo anterior
        public nodo siguiente; // señala al siguiente nodo
        public nodo(char dato)// Constructor que ejecuta al crear una instancia de string
        //constructor: metodo que tiene el mismo nombre de la clase, para llamar otros metodos.
        {
            this.dato = dato;
            siguiente = null; //Se crea sin algun nodo siguiente
            anterior = null; // se crea sin algun nodo anterior
        }

    }
    class ListaDB //CREA CLASE DE LISTA
    {
        private nodo cabeza;
        private nodo cola;
        public ListaDB() { cabeza = null; cola = null; }

        public void InsertarF(char dato) // INSERTA AL FINAL PERO NO SE UTILIZA EN ESTE EJERCICIO
        {
            nodo nuevo = new nodo(dato);
            if (cabeza == null) { cabeza = nuevo; cola = nuevo; }
            else { cola.siguiente = nuevo; nuevo.anterior = cola; cola = nuevo; }
        }
        public void InsertarI(char dato)//INSERTA AL INICIO PERO NO SE UTILIZA EN ESTE EJERCICIO
        {
            nodo nuevo = new nodo(dato);
            if (cabeza == null) { cabeza = nuevo; cola = nuevo; }
            else { nuevo.siguiente = cabeza; cabeza.anterior = nuevo; }
        }
        public void Recorrer()//RECORRE LA LISTA PARA MOSTRARLA. NO SE UTILIZA EN ESTE EJERCICIO
        {
            nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.dato + " ");
                actual = actual.siguiente;
            }
            Console.WriteLine();
        }
        public void Mostrar() //MUESTRA LA LISTA DESDE INICIO A FIN
        {
            nodo actual = cabeza;
            while (actual != null) { Console.Write(actual.dato);
                actual = actual.siguiente;
            }
        }
        public void EliminarI()// ELIMINA EL NODO INICIAL DE LA LISTA. NO SE UTILIZA EN ESTE EJERCICIO
        {
            if (cabeza == null)
            {
                Console.WriteLine("LA LISTA ESTA VACIA.");
                return;
            }

            if (cabeza == cola) // Si solo hay un nodo
            {
                cabeza = null;
                cola = null;
            }
            else
            {
                cabeza = cabeza.siguiente;
                cabeza.anterior = null;
            }
        }

        public void Ordenacion()//METODO PARA ORDENAR LAS LETRAS MEDIANTE COMPARADOR
        {
            if (cabeza == null) { return; }
            bool vicente2 = false;
            while (vicente2 == false) 
            {
                vicente2 = true;
                nodo actual = cabeza;
                while (actual.siguiente != null) 
                {
                    if (actual.dato > actual.siguiente.dato) //UTILIZA COMPARACION MEDIANTE ASCII 
                    {
                     (actual.dato, actual.siguiente.dato)= (actual.siguiente.dato, actual.dato);
                        //ESTO HACE EL INTERCAMBIO
                        vicente2 = false ;
                    }
                    actual= actual.siguiente;
                }
            }
        }
        public void AgregarLista(char dato)//METODO PARA AGREGAR CARACTERES A LA LISTA
        {
            nodo nuevo = new nodo(dato);
            if (cabeza == null)
            {
                cabeza = nuevo;
                cola = nuevo;
            }
            else
            {
                cola.siguiente = nuevo;
                nuevo.anterior = cola;  
                cola = nuevo;
            }
        }

        class Program
        {
            static void Main()
            {
                bool vicente = true;
                Console.WriteLine("             INGRESE UNA PALABRA Y EL PROGRAMA OTORGARÁ UNA");
                Console.WriteLine("           LISTA EN ORDEN ALFABETICO. (SE REPETIRAN REPETIDOS)");
                Console.WriteLine("                    ESCRIBA  (salir) PARA CONCLUIR.");
                while (vicente == true)
                {
                    Console.WriteLine("\nINGRESE UNA PALABRA: ");
                    string palabra = Console.ReadLine();
                    string palabra2 = palabra.ToLower();
                    if (palabra2 == "salir") { vicente = false; }
                    if (palabra2.Any(char.IsDigit)|| palabra2.Contains(" ")) { Console.WriteLine("ERROR. LA PALABRA NO DEBE DE CONTENER NUMEROS NI ESPACIOS"); } 
                   //VALIDA QUE NO SE ENCUENTRE NINGUN NUMERO O CARACTER ANTES DE CONTINUAR
                    else
                    
                    {
                        if (palabra2 == "salir") { Console.WriteLine("CERRANDO PROGRAMA"); }
                        else
                        {
                            ListaDB lista = new ListaDB();

                            foreach (char c in palabra)
                            {

                                lista.AgregarLista(c);
                            }
                            lista.Ordenacion();
                            Console.Write("PALABRA ORDENADA: ");
                            lista.Mostrar();
                            Console.WriteLine();
                        }
                    }   
                }
            }
        }
    }
}