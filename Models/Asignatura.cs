namespace Models;

class Asignatura
{
    public string Nombre { get; set; }
    public int Creditos { get; set; }

    public Asignatura(string nombre, int creditos)
    {
        Nombre = nombre;
        Creditos = creditos;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Asignatura: {Nombre}, Créditos: {Creditos}");
      //  Console.WriteLine("Asignatura: " + Nombre + " Créditos: " + Creditos);
    }
}

/*
        public void AñadirAsignatura(Asignatura asignatura)
        {
            if (asignaturas.Any(a => a.Nombre == asignatura.Nombre))
            {
                Console.WriteLine($"La asignatura {asignatura.Nombre} ya existe en el programa.");
            }
            else
            {
                // Añadir la asignatura a la lista global
                asignaturas.Add(asignatura);
                Console.WriteLine($"La asignatura {asignatura.Nombre} ha sido añadida.");
            }
        }
    }*/