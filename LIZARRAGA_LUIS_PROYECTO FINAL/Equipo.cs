using System;
using System.Collections.Generic;
using System.Linq;

public class Equipo
{
    // ATRIBUTOS
    private string nombre;
    private List<Jugador> jugadores;

    // PROPIEDADES
    public string Nombre { get => nombre; set => nombre = value; }
    public List<Jugador> Jugadores { get => jugadores; }

    // CONSTRUCTOR
    public Equipo(string nombre)
    {
        this.nombre = nombre;
        this.jugadores = new List<Jugador>();
    }

    // METODOS
    public void AgregarJugador(Jugador jugador)
    {
        jugadores.Add(jugador);
        Console.WriteLine($"{jugador.Nombre} se ha unido a {Nombre}");
    }

    public void RemoverJugador(Jugador jugador)
    {
        if (jugadores.Remove(jugador))
            Console.WriteLine($"{jugador.Nombre} ha dejado el equipo {Nombre}");
        else
            Console.WriteLine($"{jugador.Nombre} no está en el equipo");
    }

    public void MostrarJugadores()
    {
        Console.WriteLine($"Jugadores de {Nombre}:");
        foreach (var jugador in jugadores)
        {
            Console.WriteLine($"- {jugador.GetInfo()}");
        }
    }

    public Dictionary<string, int> CalcularEstadisticas()
    {
        return new Dictionary<string, int>
        {
            {"TotalGoles", jugadores.Sum(j => j.Goles)},
            {"TotalAmarillas", jugadores.Sum(j => j.TarjetasAmarillas)},
            {"TotalRojas", jugadores.Sum(j => j.TarjetasRojas)}
        };
    }
}