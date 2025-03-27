using System.Drawing;
using System.Net.Http.Headers;

namespace EJERCICIO_METODO_DE_INSERCION
{
    //INSTRUCCIONES: 1. SOLICITAR AL USUARIO QUE INGRESE EL TAMAÑO DEL
    // VECTOR(ARREGLO) DESEADO.
    //2. PERMITIR AL USUARIO INGRESAR MANUALMENTE LOS DATOS DEL VECTOR.
    //3. IMPLEMENTAR EL METODO DE INSERCION PARA ORDENAR LOS DATOS INGRESADOS.
    //4. MOSTRAR EL VECTOR ORIGINAL Y EL VECTOR ORDENADO.
  
}


internal class Program
{

    static void Main(string[] args)
    {
        int cont = 0;
        Console.WriteLine("INGRESE EL TAMAÑO DEL VECTOR");
        string input = (Console.ReadLine());
        if (int.TryParse(input, out int result) && result != 0) //VALIDACION
        { int[] lista = new int[result];
            while (cont < result) {
                Console.WriteLine("INGRESE UN NUMERO A GUARDAR EN LA LISTA: ");
                string input2 = (Console.ReadLine());
                if (int.TryParse(input2, out int result2))//OTRA VALIDACION
                {
                    lista[cont] = result2;
                    cont++;
                }

            }
            Console.WriteLine("ARREGLO ORIGINAL:");MostrarArreglo(lista);
            MDInsercion(lista);
            Console.WriteLine(" "); Console.WriteLine(" "); Console.WriteLine(" ");
            Console.WriteLine("ARREGLO ORDENADO: ");MostrarArreglo(lista);

        } else { Console.WriteLine("ERROR, INGRESE UN NUMERO."); }


        static void MostrarArreglo(int[] arreglo)
        {
            foreach (var num in arreglo)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
       static void MDInsercion(int[] Arreglo)
    {
        for (int i = 1; i < Arreglo.Length; i++) 
        {
            int actual = Arreglo[i]; // ELEMENTO A INSERTAR
            int a = i - 1; // POSICION DEL ELEMENTO ANTERIOR

            // MOVIMIENTO DE LOS ELEMENTOS
            while (a >= 0 && Arreglo[a] > actual)
            {
                Arreglo[a + 1] = Arreglo[a]; // DESPLAZAMIENTO A LA DERECHA
                a--; // AVANCE
            }

            // COLOCA EL ELEMENTO
            Arreglo[a + 1] = actual;
        }
    }
    } 
}

