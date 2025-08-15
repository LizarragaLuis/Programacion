using System;

public class Partido
{
    // ME PARECIO MAS FACIL USAR EL "ENUM" PORQUE DE OTRA FORMA ME COMPLICABA MUCHO
    public enum EstadoPartido { Programado, EnJuego, Finalizado }

    // Atributos
    private Equipo equipoLocal;
    private Equipo equipoVisitante;
    private int golesLocal;
    private int golesVisitante;
    private EstadoPartido estado;

    // PROPIEDADES
    public Equipo EquipoLocal { get => equipoLocal; }
    public Equipo EquipoVisitante { get => equipoVisitante; }
    public int GolesLocal { get => golesLocal; }
    public int GolesVisitante { get => golesVisitante; }
    public EstadoPartido Estado { get => estado; }

    // CONSTRUCTOR
    public Partido(Equipo local, Equipo visitante)
    {
        this.equipoLocal = local;
        this.equipoVisitante = visitante;
        this.golesLocal = 0;
        this.golesVisitante = 0;
        this.estado = EstadoPartido.Programado;
    }

    // METODOS
    public void IniciarPartido()
    {
        estado = EstadoPartido.EnJuego;
        Console.WriteLine($"Comienza el partido: {equipoLocal.Nombre} vs {equipoVisitante.Nombre}");
    }

    public void MarcarGolLocal(Jugador jugador)
    {
        if (estado != EstadoPartido.EnJuego) return;

        golesLocal++;
        jugador.MarcarGol();
        Console.WriteLine($"Gol de {equipoLocal.Nombre}! Marcado por {jugador.Nombre}");
    }

    public void MarcarGolVisitante(Jugador jugador)
    {
        if (estado != EstadoPartido.EnJuego) return;

        golesVisitante++;
        jugador.MarcarGol();
        Console.WriteLine($"Gol de {equipoVisitante.Nombre}! Marcado por {jugador.Nombre}");
    }

    public void FinalizarPartido()
    {
        estado = EstadoPartido.Finalizado;
        Console.WriteLine($"Final del partido: {equipoLocal.Nombre} {golesLocal} - {golesVisitante} {equipoVisitante.Nombre}");
    }

    public string GetResultado()
    {
        return $"{equipoLocal.Nombre} {golesLocal} - {golesVisitante} {equipoVisitante.Nombre}";
    }
}