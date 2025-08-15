using System;

public class Jugador : Persona
{
    // ATRIBUTOS
    private int numeroCamiseta;
    private string posicion;
    private int goles;
    private int tarjetasAmarillas;
    private int tarjetasRojas;

    // PROPIEDADES
    public int NumeroCamiseta { get => numeroCamiseta; set => numeroCamiseta = value; }
    public string Posicion { get => posicion; set => posicion = value; }
    public int Goles { get => goles; private set => goles = value; }
    public int TarjetasAmarillas { get => tarjetasAmarillas; private set => tarjetasAmarillas = value; }
    public int TarjetasRojas { get => tarjetasRojas; private set => tarjetasRojas = value; }

    // CONSTRUCTOR
    public Jugador(string nombre, int edad, string nacionalidad,
                  int numeroCamiseta, string posicion)
        : base(nombre, edad, nacionalidad)
    {
        this.numeroCamiseta = numeroCamiseta;
        this.posicion = posicion;
        this.goles = 0;
        this.tarjetasAmarillas = 0;
        this.tarjetasRojas = 0;
    }

    // METODOS
    public void MarcarGol()
    {
        Goles++;
        Console.WriteLine($"{Nombre} ha marcado un gol! Total: {Goles}");
    }

    public void RecibirTarjeta(string tipoTarjeta)
    {
        if (tipoTarjeta.ToLower() == "amarilla")
        {
            TarjetasAmarillas++;
            Console.WriteLine($"Tarjeta amarilla para {Nombre}");
        }
        else if (tipoTarjeta.ToLower() == "roja")
        {
            TarjetasRojas++;
            Console.WriteLine($"Tarjeta roja para {Nombre}. Expulsado!");
        }
        if (TarjetasAmarillas == 2) {
            Console.WriteLine($"Expulsado el jugador {Nombre} por " +
            $"tener dos tarjetas amarillas!.");
        }
    }

    public void CambiarPosicion(string nuevaPosicion)
    {
        Posicion = nuevaPosicion;
        Console.WriteLine($"{Nombre} ahora juega como {Posicion}");
    }

    public void MostrarEstadisticas()
    {
        Console.WriteLine($"Estadísticas de {Nombre}:");
        Console.WriteLine($"- Goles: {Goles}");
        Console.WriteLine($"- Tarjetas amarillas: {TarjetasAmarillas}");
        Console.WriteLine($"- Tarjetas rojas: {TarjetasRojas}");
    }

    // OVERRIDE
    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Número: {NumeroCamiseta}, Posición: {Posicion}, " +
               $"Goles: {Goles}, Tarjetas Amarillas: {TarjetasAmarillas}, " +
               $"Tarjetas Rojas: {TarjetasRojas}";
    }
}