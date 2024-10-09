using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de personas
        List<Persona> personas = new List<Persona>();

        // Agregar personas a la lista
        personas.Add(new Estudiante("Belen", "Mamani", 28, "123456", 2020345, "Ingeniería"));
        personas.Add(new Docente("Rodrigo", "Veizaga", 38, "789012", "Programación", 10));
        personas.Add(new Administrativo("Karen", "Lizarazu", 25, "345678", "Recursos Humanos", "Jefa de Personal"));
        personas.Add(new Estudiante("Juan", "Pérez", 20, "901234", 2020346, "Ingeniería"));
        personas.Add(new Docente("María", "García", 38, "567890", "Matemáticas", 15));
        personas.Add(new Estudiante("jose", "Peredo", 24, "989765", 20256546, "Pasteleria"));

        // Mostrar información de las personas
        foreach (var persona in personas)
        {
            Console.WriteLine(persona.ToString());
        }
    }
}

public abstract class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public string Identificacion { get; set; }

    public Persona(string nombre, string apellido, int edad, string identificacion)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Identificacion = identificacion;
    }

    public override string ToString()
    {
        return $"{Nombre} {Apellido}, Edad: {Edad}, ID: {Identificacion}";
    }
}

public class Estudiante : Persona
{
    public int Matricula { get; set; }
    public string Carrera { get; set; }

    public Estudiante(string nombre, string apellido, int edad, string identificacion, int matricula, string carrera)
        : base(nombre, apellido, edad, identificacion)
    {
        Matricula = matricula;
        Carrera = carrera;
    }

    public override string ToString()
    {
        return base.ToString() + $", Matrícula: {Matricula}, Carrera: {Carrera}";
    }
}

public class Docente : Persona
{
    public string Materia { get; set; }
    public int AñosExperiencia { get; set; }

    public Docente(string nombre, string apellido, int edad, string identificacion, string materia, int añosExperiencia)
        : base(nombre, apellido, edad, identificacion)
    {
        Materia = materia;
        AñosExperiencia = añosExperiencia;
    }

    public override string ToString()
    {
        return base.ToString() + $", Materia: {Materia}, Años de experiencia: {AñosExperiencia}";
    }
}

public class Administrativo : Persona
{
    public string Departamento { get; set; }
    public string Cargo { get; set; }

    public Administrativo(string nombre, string apellido, int edad, string identificacion, string departamento, string cargo)
        : base(nombre, apellido, edad, identificacion)
    {
        Departamento = departamento;
        Cargo = cargo;
    }

    public override string ToString()
    {
        return base.ToString() + $", Departamento: {Departamento}, Cargo: {Cargo}";
    }
}
