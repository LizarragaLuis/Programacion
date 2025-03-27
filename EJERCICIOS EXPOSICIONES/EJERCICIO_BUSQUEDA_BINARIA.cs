namespace EJERCICIO_BUSQUEDA_BINARIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] LISTA = {1, 5, 10, 1000, 21, 30, 69, 420, 43 };
            Console.WriteLine("INGRESE UN NUMERO A BUSCAR: ");
            int numero = int.Parse(Console.ReadLine());
            int iz = 0;
            int der = LISTA.Length -1;
            while (iz < der)
            { 
            int medio = (iz  + der)/2;
                if (LISTA[medio] == numero)
                {
                    Console.WriteLine($"NUMERO ENCONTRADO EN LA POSICION {medio}");
                    return;
                }
                else if (LISTA[medio] < numero) { iz = medio + 1; }
                else { der = medio - 1; }
            }
            Console.WriteLine("NUMERO NO ENCONTRADO");
        }
    }
}
