using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoLibrary.Domain.Entities;

public partial class Libro
{
    [Key]
    public int LibroId { get; set; }

    public string Titulo { get; set; } = null!;

    public int? AutorId { get; set; }

    public int? CategoriaId { get; set; }

    public DateOnly? FechaPublicacion { get; set; }

    public decimal? Precio { get; set; }
}
