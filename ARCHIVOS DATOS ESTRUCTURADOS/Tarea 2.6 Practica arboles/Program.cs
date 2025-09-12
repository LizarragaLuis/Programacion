namespace Tarea_2._6_Practica_arboles
{
    class nodo
    {
        public string pregunta;
        public nodo i;
        public nodo d;
        public nodo(string pregunta) 
        {
         this.pregunta = pregunta;
            i = null; //izquierda
            d = null;//derecha
        }
    }
    class ADiagnostico 
    {
        private nodo r; //raiz
        public ADiagnostico()
        { 
        //CREAMOS EL ARBOL DE DECISIONES
        r = new nodo ("¿Tiene fiebre alta o baja?");
            r.i = new nodo("¿Tiene dolor de garganta?");
            r.i.i = new nodo("ES POSIBLE QUE TENGA UN RESFRIADO COMUN.");
            r.i.d = new nodo("¿Tiene dolor corporal intenso o leve?");
            r.i.d.i = new nodo("ES POSIBLE QUE TENGA CHIKUNGUYA/DENGUE.");
            r.i.d.d = new nodo("ES POSIBLE QUE TENGA UN GOLPE DE CALOR.");
            r.d = new nodo("¿Tiene dolor en el pecho?");
            r.d.i = new nodo("¿Tiene tos con flemas?");
            r.d.i.i = new nodo("ES POSIBLE QUE TENGA BRONQUITIS.");
            r.d.i.d = new nodo("¿Tiene tos seca?");
            r.d.i.d.i = new nodo("ES POSIBLE QUE TENGA COVID_19.");
            r.d.i.d.d = new nodo("¿Tiene fatiga?");
            r.d.i.d.d.i = new nodo("ES POSIBLE QUE TENGA MIOCARDIOPATIA.");
            r.d.i.d.d.d = new nodo("ES POSIBLE QUE TENGA INDICIOS DE UN INFARTO, VAYA A URGENCIAS IMMEDIATAMENTE.");
            r.d.d = new nodo("¿Tiene dolor de cabeza?");
            r.d.d.i = new nodo("¿Es dolor intenso?");
            r.d.d.i.i = new nodo("ES POSIBLE QUE TENGA MIGRAÑA.");
            r.d.d.i.d = new nodo("¿Toma la cantidad de agua natural que se requiere diariamente?");
            r.d.d.i.d.i = new nodo("ES POSIBLE QUE SEA DESHIDRATACION, REPOSE Y TOME AGUA");
            r.d.d.i.d.d = new nodo("ES POSIBLE QUE SEA FATIGA, SE SUGIERE REPOSAR.");
            r.d.d.d = new nodo("¿Tiene ardor o dolor estomacal?");
            r.d.d.d.i = new nodo("¿Tiene el estomago inflamado?");
            r.d.d.d.i.i = new nodo("ES POSIBLE QUE TENGA GASTRITIS.");
            r.d.d.i.i.d = new nodo("ES POSIBLE QUE TENGA REFLUJO.");

            r.d.d.d.d = new nodo("ES NECESARIO MAS INFORMACION. PASE A LA VENTANILLA DE LA DERECHA.");
        }
        public void IDiagnostico()
        {
            nodo actual = r;
            while (actual.i != null && actual.d != null)
            {
                Console.WriteLine(actual.pregunta + " (si/no)");
                string respuesta = Console.ReadLine().ToLower();
                if (respuesta == "si")
                { actual = actual.i; }
                else if (respuesta == "no")
                { actual = actual.d; }
                else { Console.WriteLine("RESPONDA UNICAMENTE CON SI O NO."); }
            }
            Console.WriteLine(actual.pregunta);
        }
     
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ADiagnostico arbol = new ADiagnostico();
            Console.WriteLine("Bienvenido al sistema de diagnóstico médico.");
            Console.WriteLine("Por favor responda las siguientes preguntas con'sí' o 'no'.");
            
// Iniciar el diagnóstico
            arbol.IDiagnostico();
        }
    }
}
