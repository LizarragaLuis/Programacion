namespace EJERCICIO_BUSQUEDA_SECUENCIAL
{
    //ESCRIBE UN PROGRAMA EN C# QUE REALICE UNA BUSQUEDA SECUENCIAL EN UN
    //ARREGLO DE NOMBRES. EL PROGRAMA DEBE:
    //1. SOLICITAR AL USUARIO QUE INGRESE UN NOMBRE PARA BUSCAR
    //2. BUSCAR EL NOMBRE EN EL ARREGLO: [INGRID,VICENTE,LUIS,ALEJANDRO,
    //JULIO, ANTONIO]
    //3. INDICAR SI EL NOMBRE FUE ENCONTRADO Y SU POSICION, O SI NO SE ENCUENTRA.
    class BusquedaSecuencial
    {
        static int BuscarSecuencial(string[] arreglo, string valorBuscado)
        {
            // RECORRE EL ARREGLO
            for (int i = 0; i < arreglo.Length; i++)
            {
                // DEVUELVE LA UBICACION SI ENCUENTRA EL NOMBRE BUSCADO
                if (arreglo[i] == valorBuscado)
                {
                    return i;
                }
            }
            return -1;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                string nombretotal = "a";
                string[] numeros = { "INGRID", "LUIS", "JULIO", "ANTONIO", "ALEJANDRO", "VICENTE" };
                Console.WriteLine("INGRESE UN NOMBRE A BUSCAR DE LOS ESTUDIANTES DE TI DE CUARTO DEL TURNO VESPERTINO");
                string nombreBuscado = Console.ReadLine();
                nombretotal = nombreBuscado.ToUpper();
                int pos = BuscarSecuencial(numeros, nombretotal);
                if (pos != -1) { Console.WriteLine($"El nombre {nombretotal} se encontró en la posición {pos + 1}"); }
                else Console.WriteLine($"El nombre {nombretotal} no se encontró en el arreglo.");
            }
        }
    }
}
