using System.Text;
using System.Security.Cryptography;

namespace EJERCICIO_METODO_HASH
{
    //   La bibliotecaria quiere organizar 5 libros en estantes
    // numerados del 1 al 4. Cada libro tiene un número único
    //que representa su código.
    class Program
    {
        static void Main()
        {
            int[] libros = { 4402, 253, 6804, 403,100 }; // CODIGOS DE LOS LIBROS SIN HASHIFICAR
            Dictionary<int, List<int>> estantes = new Dictionary<int, List<int>>(); //DICCIONARIO

         
            for (int i = 0; i < 4; i++)
            {
                estantes[i] = new List<int>(); //FOR, UTILIZADO PARA LOS ESTANTES, QUE SON 4
            }

            // ASIGNACION DE LIBRO AL ESTANTE
            foreach (int libro in libros)
            {
                int estante = libro % 4; //FUNCION HASH PARA LOS ESTANTES
                estantes[estante].Add(libro);
            }

           

            // IMPRESION DEL CODIGO HASH INDIVIDUAL DE CADA LIBRO
            Console.WriteLine("\n                   Códigos hash de los libros:");
            foreach (int libro in libros)
            {
                string hash = ObtenerHashSHA256(libro.ToString());
                Console.WriteLine($"Hash del libro #{libro}: {hash}");
            }
            Console.WriteLine(" ");
            //MOSTRAR LOS LIBROS EN LOS ESTANTES
            Console.WriteLine("           Distribución de libros en los estantes:");
            foreach (var estante in estantes)
            {
                Console.WriteLine($"Estante {estante.Key+1}: {string.Join(", ", estante.Value)}");
            }
        }


        // METODO DE OBTENCION DE HASH EN UN STRING
        static string ObtenerHashSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder resultado = new StringBuilder();
                foreach (byte b in bytes)
                    resultado.Append(b.ToString("x2"));
                return resultado.ToString();
            }
        }
    }
}
