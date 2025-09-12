using System.Net.Mail;

namespace _2._4_Practicas_Enlazadas_Ejercicio_1__240085
{
    class Nodo
    { //nodo de la lista
        public int dato; //variable para almacenar el valor del nodo
        public Nodo siguiente;// Apuntador al nodo siguiente de la lista.
        public int Coeficiente;
        public int Exponente;
    }
    //definicion de la lista de nodos
    class Lista
    {
        public Nodo inicio; //cabeza de la lista
        public Lista() { inicio = null; }


        //forma de insertar al final de la lista, equivalente al ArrayList
        public void InsertarF(int item)
        {
            Nodo aux = new Nodo(); // nodo temporal, todavia no pertenece a la lista
            aux.dato = item; //Almacena en el atributo "dato" el valor recibido
                             //en el parametro
            aux.siguiente = null;//apuntador señala a nulo
            if (inicio == null) { inicio = aux; }// nodo se vuelve cabeza
            else
            {
                Nodo puntero; //se usa para recorrer la lista, sin mover la cabeza
                puntero = inicio;//señala al mismo nodo que "inicio"
                while (puntero.siguiente != null)
                { puntero = puntero.siguiente; }// se deszplaza por todos los nodos de la lista
                puntero.siguiente = aux; // ultimo nodo señala al auxiliar (aux)

            }
        }
        //forma de insertar al inicio de la lista (cabeza)
        public void InsertarI(int item)
        {
            Nodo aux = new Nodo();//nodo temporal agregado a la lista
            aux.dato = item; //almacena valor en el atributo dato
            aux.siguiente = null; //puntero señala a nulo
            if (inicio == null) { inicio = aux; } //esta vacia la cola se vuelve cabeza
            else
            {
                Nodo puntero; puntero = inicio; // dos apuntadores señalan al mismo nodo
                inicio = aux; // asignan la cabeza como aux
                aux.siguiente = puntero; //el puntero de auxiliar que ahora es cabeza
                                         //se enlaza con el nodo que era antes la cabeza que tiene apuntado el entero
            }
        }
        public void mostrar()
        {
            if (inicio == null) { Console.WriteLine("LISTA VACIA."); }
            else
            {
                Nodo puntero;
                puntero = inicio; //se empieza el conteo en el mismo nodo que la cabeza
                Console.Write("{0} -> \t", puntero.dato);
                // imprime valor de nodo. Write y no Writeline
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; //avanza un nodo en la lista
                    Console.Write("{0} -> \t", puntero.dato);//se usa write para que la linea no se salte
                }
                Console.WriteLine();
            }

        }
    }
    
   
        internal class Program
        {
            static void Main(string[] args)
            {
              bool   vicente = true;
                Lista poli = new Lista();
            Console.WriteLine("*****     BIENVENIDO A SISTEMA DE DERIVACION DE POLINOMIOS     *****");
            while (vicente == true) 
                {
                Console.Clear();
                Console.WriteLine("     INGRESE LOS TÉRMINOS DEL POLINOMIO (COEFICIENTE Y EXPONENTE)");
                Console.WriteLine("     EJEMPLO: 10,5 PARA ESCRIBIR 10X ELEVADO A LA QUINTA POTENCIA.");
                Console.WriteLine("     UTILICE COMA (,) PARA SEPARAR EL COEFICIENTE DEL EXPONENTE.");
                Console.WriteLine("     PRESIONE ENTER SIN ESCRIBIR ALGO SI ESTA LISTO PARA DERIVAR.");
                string entrada = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entrada)) { vicente = false; }
                
                }
                
                
            }
        }
    
}
