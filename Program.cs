using Models;

ProgramaEducativo programa = new ProgramaEducativo();

// Crear asignaturas
Asignatura servidor = new Asignatura("Servidor", 6);
var cliente = new Asignatura("Cliente", 4);
Asignatura diseño = new("Diseño", 8);

// Crear estudiantes
var estudiante1 = new Estudiante("Vanessa Llorente");
Estudiante estudiante2 = new Estudiante("Alejandro Giménez");
Estudiante estudiante3 = new Estudiante("Pepe Villuela");
Estudiante estudiante4 = new Estudiante("Pedro Sánchez");

// Añadir estudiantes al programa educativo
programa.AñadirEstudiante(estudiante1);
programa.AñadirEstudiante(estudiante2);
programa.AñadirEstudiante(estudiante3);
programa.AñadirEstudiante(estudiante4);


// Asignar calificaciones
estudiante1.AñadirCalificacion(servidor, 9.5);
estudiante1.AñadirCalificacion(cliente, 8.0);
estudiante1.AñadirCalificacion(diseño, 9.0);

estudiante2.AñadirCalificacion(servidor, 7.5);
estudiante2.AñadirCalificacion(cliente, 8.5);

estudiante3.AñadirCalificacion(servidor, 7.5);
estudiante3.AñadirCalificacion(cliente, 7.5);
estudiante3.AñadirCalificacion(diseño, 9.5);

estudiante4.AñadirCalificacion(servidor, 3.5);
estudiante4.AñadirCalificacion(cliente, 9.5);
estudiante4.AñadirCalificacion(diseño, 2.5);


// Mostrar estudiantes
programa.MostrarEstudiantes();

// Mostrar calificaciones de un estudiante específico
Estudiante estudianteSeleccionado = programa.ObtenerEstudiante("Vanessa Llorente");
if (estudianteSeleccionado != null)
{
    estudianteSeleccionado.MostrarCalificaciones();
    double promedio = estudianteSeleccionado.CalcularPromedio();
    Console.WriteLine($"Promedio de {estudianteSeleccionado.Nombre}: {promedio:F2}");
}

// Mostrar calificaciones del segundo estudiante
estudianteSeleccionado = programa.ObtenerEstudiante("Alejandro Giménez");
if (estudianteSeleccionado != null)
{
    estudianteSeleccionado.MostrarCalificaciones();
    double promedio = estudianteSeleccionado.CalcularPromedio();
    Console.WriteLine($"Promedio de {estudianteSeleccionado.Nombre}: {promedio:F2}");
}


//1. Modifica la calificación de una asignatura específica
estudiante3.ModificarCalificacion(diseño, 5.5);

// 2. Agrega una función en el programa educativo que permita eliminar a un estudiante por su nombre
programa.EliminarEstudiante("Pepe Villuela");


//3.Implementa la funcionalidad de búsqueda de estudiantes por una parte de su nombre
programa.BuscarEstudiantesPorNombre("Van");

//Añade una funcionalidad que calcule el promedio global de todos los estudiantes del programa educativo.
Console.WriteLine(Math.Truncate(programa.CalcularPromedioGlobal()));


