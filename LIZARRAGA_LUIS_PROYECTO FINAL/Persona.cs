using System;

public class Persona
{
    // ATRIBUTOS
    private string nombre;
    private int edad;
    private string nacionalidad;

    // PROPIEDADES
    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
    public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }

    // CONSTRUCTOR
    public Persona(string nombre, int edad, string nacionalidad)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.nacionalidad = nacionalidad;
    }

    // METODO
    public virtual string GetInfo()
    {
        return $"Nombre: {Nombre}, Edad: {Edad}, Nacionalidad: {Nacionalidad}";
    }
}