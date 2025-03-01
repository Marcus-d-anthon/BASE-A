using System;
using System.Collections.Generic;

namespace ExamenBASEA.Models;

public partial class Libro
{
    public int LibroId { get; set; }

    public string? Titulo { get; set; }

    public string? Autor { get; set; }

    public string? Editorial { get; set; }

    public DateOnly? AnioPublicacion { get; set; }

    public string? Isbn { get; set; }

    public string? Genero { get; set; }

    public int? NumeroPaginas { get; set; }

    public string? Idioma { get; set; }

    public string? Estado { get; set; }

    public DateOnly? FechaCreacion { get; set; }
}
