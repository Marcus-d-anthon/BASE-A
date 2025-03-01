using System;
using System.Collections.Generic;

namespace ExamenBASEA.Models;

public partial class Estudiante
{
    public int EstudianteId { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    public string? Genero { get; set; }

    public string? Carrera { get; set; }

    public string? Semestre { get; set; }

    public string? Telefono { get; set; }

    public string? Email { get; set; }

    public string? Estado { get; set; }

    public DateOnly? FechaCreacion { get; set; }
}
