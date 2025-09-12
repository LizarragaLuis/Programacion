namespace ConsoleApp2
{
   using System.Collections.Generic;
    

    internal class Program
    {
        static void Main(string[] args)
        {
            List<(int Id, string NombreApellido, string Color)> meseros = new List<(int, string, string)>();
            meseros.Add((1, "Hugo", "Red"));
            meseros.Add((2, "Paco", "Green"));
            meseros.Add((3, "Alejandro Ronaldo", "Blue"));
            foreach (var mesero in meseros)
            {
                if (Enum.TryParse(mesero.Color, true, out ConsoleColor colorConsola))
                { Console.ForegroundColor = colorConsola; }
                else { Console.ForegroundColor = ConsoleColor.White; }
                Console.WriteLine($"ID: {mesero.Id}, Nombre: {mesero.NombreApellido}, Color: {mesero.Color}");

            }
            Console.ResetColor(); 





        }
    }
}
