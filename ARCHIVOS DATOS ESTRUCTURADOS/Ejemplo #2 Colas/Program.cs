using System.Reflection.Metadata.Ecma335;

namespace Ejemplo__2_Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = false;
            Queue<string> cola = new Queue<string>();
            cola.Enqueue("p1");
            cola.Enqueue("p2");
            cola.Enqueue("p3");

            Console.WriteLine($"Primero en la cola: {cola.Peek()}");
            Console.WriteLine($"Atendiendo a: {cola.Dequeue()}");
            Console.WriteLine("Personas en la cola: ");
            foreach (var person in cola)
            {
                Console.WriteLine(person);
            }
            //While filabanco.count > 0) {Console.WriteLine($"Atendiendo a: {filaBanco.DDequeue()}";}Console.WriteLine("No hay mas clientes en la fila. ")


   
        }

}
}
