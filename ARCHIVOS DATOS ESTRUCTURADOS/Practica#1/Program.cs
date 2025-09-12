namespace Practica_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            // Stack<string> nombres = new Stack<string>(); nombres.Push("Hugo"); nombres.Push("Paco"); nombres.Push("Luis");Console.WriteLine("Nombres almacenados en la pila: ");while (nombres.Count > 0){string nombre = nombres.Pop(); Console.WriteLine(nombre); }
            //Ingrese un numero en decimal y que nos diga el valor en binario, octal y hexadecimal
            Console.WriteLine("Bienvenido al convertidor de decimal a sistemas numericos, a que numero desea convertir? ");Console.WriteLine("Opciones actuales: binario(Opcion 1), octal(opcion 2), hexadecimal(Opcion 3)");
                ; int respuesta = int.Parse(Console.ReadLine());
        switch (respuesta)
            {
                case 1:
                    float r = 0;
                    Console.WriteLine("Ingrese el numero que desea convertir a binario: "); float n1 = float.Parse(Console.ReadLine());
                    Stack<float> ayylmao = new Stack<float>();
                    float hold = n1;
                    while (hold != 0)
                    { r = (hold % 2); float c = (hold / 2); ayylmao.Push(r); hold = (float)Math.Floor(c);}
                    Console.Write("El numero {0} convertido a binario es de: ", n1);
                    while (ayylmao.Count > 0) { float resultado = ayylmao.Pop();Console.Write("{0}",resultado);}
                    break;
                case 2:
                     r = 0;
                    Console.WriteLine("Ingrese el numero que desea convertir a octal: ");  n1 = float.Parse(Console.ReadLine());
                    ayylmao = new Stack<float>();
                     hold = n1;
                    while (hold != 0)
                    { r = (hold % 8); float c = (hold / 8); ayylmao.Push(r); hold = (float)Math.Floor(c); }
                    Console.Write("El numero {0} convertido a octal es de: ", n1);
                    while (ayylmao.Count > 0) { float resultado = ayylmao.Pop(); Console.Write("{0}", resultado); }
                    break;
                case 3:
                    r = 0;
                    Console.WriteLine("Ingrese el numero que desea convertir a hexadecimal: "); n1 = float.Parse(Console.ReadLine());
                   Stack<string> ayylmao2 = new Stack<string>();
                    hold = n1;
                    while (hold != 0)
                    { r = (hold % 16); float c = (hold / 16); 
                        
                        switch (r){ default: ayylmao2.Push(r.ToString()); break; case 10: ayylmao2.Push("A"); break; case 11: ayylmao2.Push("B"); break;
                        case 12: ayylmao2.Push("C"); break; case 13: ayylmao2.Push("D"); break; case 14: ayylmao2.Push("D"); break;
                        case 15: ayylmao2.Push("E"); break;case 16: ayylmao2.Push("F"); break;
                        } 
                        hold = (float)Math.Floor(c); }
                    Console.Write("El numero {0} convertido a hexadecimal es de: ", n1);
                    while (ayylmao2.Count > 0) { string resultado = ayylmao2.Pop(); Console.Write("{0}", resultado); }

                    break;
            }
                
        
        
        
        
        
        
        
        
        }
    }
}