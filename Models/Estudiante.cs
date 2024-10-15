namespace Models;

class Estudiante
{
    public string Nombre { get; set; }
    private Dictionary<Asignatura, double> calificaciones;

    public Estudiante(string nombre)
    {
        Nombre = nombre;
        calificaciones = new Dictionary<Asignatura, double>();
    }
public void AñadirCalificacion(Asignatura asignatura, double calificacion)
{
    //Verificar si la calificacion está entre los valores 0 y 10.
    if (calificacion >= 0 && calificacion <= 10){
        calificaciones[asignatura] = calificacion;
    }
    else {
        Console.WriteLine("La calificacion no es válida");
    }
}

    public void MostrarCalificaciones()
    {
        Console.WriteLine($"\n--- Calificaciones de {Nombre} ---");
        foreach (var entrada in calificaciones)
        {
            Console.WriteLine($"{entrada.Key.Nombre}: {entrada.Value:F2}");
        }
    }

    public double CalcularPromedio()
    {
        double suma = 0;
        foreach (var entrada in calificaciones)
        {
            suma += entrada.Value;
        }
        return calificaciones.Count > 0 ? suma / calificaciones.Count : 0;
    }

    public void ModificarCalificacion(Asignatura asignatura, double nuevaCalificacion)
    {
        if (calificaciones.ContainsKey(asignatura))
        {
            calificaciones[asignatura] = nuevaCalificacion;
            Console.WriteLine($"Calificación de {asignatura.Nombre} modificada a {nuevaCalificacion:F2}.");
        }
        else
        {
            Console.WriteLine($"El estudiante no tiene una calificación en {asignatura.Nombre}.");
        }
    }

}