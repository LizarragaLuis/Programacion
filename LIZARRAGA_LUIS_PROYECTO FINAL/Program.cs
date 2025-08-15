namespace LIZARRAGA_LUIS_PROYECTO_FINAL_
{
    using System;
    using System.Threading;

    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("=== SIMULADOR DE LIGA DE FÚTBOL ===");
            Console.WriteLine("Cargando simulación...\n");
            Thread.Sleep(2000);

            //  LIGA
            Liga premierLeague = new Liga("Premier League");
            Console.WriteLine($"\nLiga creada: {premierLeague.Nombre}");

            // EQUIPOS
            string[] ciudades = { "Londres", "Manchester", "Liverpool", "Birmingham", "Leeds" };
            Equipo arsenal = new Equipo("Arsenal FC");
            Equipo manUnited = new Equipo("Manchester United");

            // CREAR JUGADORES
            string[] nacionalidades = { "Inglaterra", "Brasil", "Francia", "España", "Argentina", "Portugal" };
            string[] posiciones = { "Delantero", "Mediocampista", "Defensa", "Portero" };

            Jugador[] jugadoresArsenal = {
            new Jugador("Bukayo Saka", random.Next(18, 35), nacionalidades[random.Next(nacionalidades.Length)], 7, posiciones[random.Next(posiciones.Length)]),
            new Jugador("Martin Ødegaard", random.Next(18, 35), nacionalidades[random.Next(nacionalidades.Length)], 8, posiciones[random.Next(posiciones.Length)]),
            new Jugador("Aaron Ramsdale", random.Next(18, 35), nacionalidades[random.Next(nacionalidades.Length)], 1, "Portero")
        };

            Jugador[] jugadoresManUtd = {
            new Jugador("Marcus Rashford", random.Next(18, 35), nacionalidades[random.Next(nacionalidades.Length)], 10, posiciones[random.Next(posiciones.Length)]),
            new Jugador("Bruno Fernandes", random.Next(18, 35), nacionalidades[random.Next(nacionalidades.Length)], 18, posiciones[random.Next(posiciones.Length)]),
            new Jugador("David de Gea", random.Next(18, 35), "España", 1, "Portero")
        };

            //JUGADORES A EQUIPOS
            Console.WriteLine("\nFichajes:");
            foreach (var jugador in jugadoresArsenal)
            {
                if (random.NextDouble() > 0.2) // 80% de probabilidad de fichaje
                {
                    arsenal.AgregarJugador(jugador);
                    Console.WriteLine($"{jugador.Nombre} ➡ {arsenal.Nombre}");
                    Thread.Sleep(500);
                }
            }

            foreach (var jugador in jugadoresManUtd)
            {
                if (random.NextDouble() > 0.2) // 80% de probabilidad de fichaje
                {
                    manUnited.AgregarJugador(jugador);
                    Console.WriteLine($"{jugador.Nombre} ➡ {manUnited.Nombre}");
                    Thread.Sleep(500);
                }
            }

            // EQUIPOS ANADIDOS A LA LIGA
            premierLeague.AgregarEquipo(arsenal);
            premierLeague.AgregarEquipo(manUnited);

            // PROGRAMACION DEL PARTIDO
            DateTime fechaPartido = DateTime.Now.AddDays(random.Next(1, 30));
            premierLeague.ProgramarPartido(arsenal, manUnited, fechaPartido);
            Partido partido = premierLeague.Partidos[0];

            Console.WriteLine($"\nPartido programado: {arsenal.Nombre} vs {manUnited.Nombre}");
            Console.WriteLine($"Fecha: {fechaPartido:dd/MM/yyyy}");
            Console.WriteLine("\nEl partido está por comenzar...");
            Thread.Sleep(3000);

            // COMIENZA SIMULACION
            partido.IniciarPartido();
            Console.WriteLine("\n¡Comienza el partido!\n");

            int minutos = 0;
            int maxMinutos = 90;
            int golesLocal = 0;
            int golesVisitante = 0;

            while (minutos <= maxMinutos)
            {
                if (random.NextDouble() < 0.15) // 15%
                {
                    int tipoEvento = random.Next(1, 5); // 1-4

                    if (minutos == 45) Console.WriteLine("\n=== Medio tiempo ===");

                    Console.Write($"\nMin {minutos}: ");

                    switch (tipoEvento)
                    {
                        case 1: // Gol LOCAL
                            if (arsenal.Jugadores.Count > 0)
                            {
                                var goleador = arsenal.Jugadores[random.Next(arsenal.Jugadores.Count)];
                                partido.MarcarGolLocal(goleador);
                                golesLocal++;
                            }
                            break;
                        case 2: // Gol VISITANTE
                            if (manUnited.Jugadores.Count > 0)
                            {
                                var goleador = manUnited.Jugadores[random.Next(manUnited.Jugadores.Count)];
                                partido.MarcarGolVisitante(goleador);
                                golesVisitante++;
                            }
                            break;
                        case 3: // AMARILLA
                            Equipo equipoTarjeta = random.Next(2) == 0 ? arsenal : manUnited;
                            if (equipoTarjeta.Jugadores.Count > 0)
                            {
                                var infractor = equipoTarjeta.Jugadores[random.Next(equipoTarjeta.Jugadores.Count)];
                                infractor.RecibirTarjeta("amarilla");
                            }
                            break;
                        case 4: // ROJA
                            if (random.NextDouble() < 0.3) // 30% de probabilidad siendo tarjeta roja
                            {
                                Equipo equipoExpulsado = random.Next(2) == 0 ? arsenal : manUnited;
                                if (equipoExpulsado.Jugadores.Count > 0)
                                {
                                    var expulsado = equipoExpulsado.Jugadores[random.Next(equipoExpulsado.Jugadores.Count)];
                                    expulsado.RecibirTarjeta("roja");
                                }
                            }
                            break;
                    }
                }

                minutos++;
                Thread.Sleep(500); // PAUSA ENTRE MINUTOS PARA DARLE SUSPENSO 
            }

            //SE ACABA EL PARTIDO
            partido.FinalizarPartido();
            Console.WriteLine($"\n\nResultado final: {partido.GetResultado()}");
            Thread.Sleep(200);
            // ESTADISTICAS
            Console.WriteLine("\n=== ESTADÍSTICAS FINALES ===");
            Console.WriteLine($"\n{arsenal.Nombre}:");
            foreach (var jugador in arsenal.Jugadores)
            {
                jugador.MostrarEstadisticas();
            }
            Thread.Sleep(200);
            Console.WriteLine($"\n{manUnited.Nombre}:");
            foreach (var jugador in manUnited.Jugadores)
            {
                jugador.MostrarEstadisticas();
            }
            Thread.Sleep(200);
            //  TABLA DE POSICIONES
            Console.WriteLine("\n=== TABLA DE POSICIONES ===");
            premierLeague.MostrarTablaPosiciones();

            Console.WriteLine("\nSimulación completada. Presiona dos teclas cualquiera para salir...");
            Console.ReadKey();
        }
    }
}
