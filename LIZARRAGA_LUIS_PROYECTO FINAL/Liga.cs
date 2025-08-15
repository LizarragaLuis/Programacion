using System;
using System.Collections.Generic;
using System.Linq;

public class Liga
{
    // ATRIBUTOS
    private string nombre;
    private List<Equipo> equipos;
    private List<Partido> partidos;

    // PROPIEDADES
    public string Nombre { get => nombre; set => nombre = value; }
    public List<Equipo> Equipos { get => equipos; }
    public List<Partido> Partidos { get => partidos; }

    // CONSTRUCTOR
    public Liga(string nombre)
    {
        this.nombre = nombre;
        this.equipos = new List<Equipo>();
        this.partidos = new List<Partido>();
    }

    // METODOS
    public void AgregarEquipo(Equipo equipo)
    {
        equipos.Add(equipo);
        Console.WriteLine($"{equipo.Nombre} se ha unido a la liga {Nombre}");
    }

    public void ProgramarPartido(Equipo local, Equipo visitante, DateTime fecha)
    {
        var partido = new Partido(local, visitante);
        partidos.Add(partido);
        Console.WriteLine($"Partido programado: {local.Nombre} vs {visitante.Nombre} para {fecha}");
    }

    public Dictionary<Equipo, int> GenerarTablaPosiciones()
    {
        var tabla = new Dictionary<Equipo, int>();

        foreach (var equipo in equipos)
        {
            int puntos = 0;

            foreach (var partido in partidos.Where(p => p.Estado == Partido.EstadoPartido.Finalizado))
            {
                if (partido.EquipoLocal == equipo)
                {
                    if (partido.GolesLocal > partido.GolesVisitante) puntos += 3;
                    else if (partido.GolesLocal == partido.GolesVisitante) puntos += 1;
                }
                else if (partido.EquipoVisitante == equipo)
                {
                    if (partido.GolesVisitante > partido.GolesLocal) puntos += 3;
                    else if (partido.GolesVisitante == partido.GolesLocal) puntos += 1;
                }
            }

            tabla.Add(equipo, puntos);
        }

        return tabla.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
    }

    public void MostrarTablaPosiciones()
    {
        var tabla = GenerarTablaPosiciones();

        Console.WriteLine($"Tabla de posiciones de la liga {Nombre}:");
        int posicion = 1;
        foreach (var item in tabla)
        {
            Console.WriteLine($"{posicion}. {item.Key.Nombre} - {item.Value} puntos");
            posicion++;
        }
    }
}