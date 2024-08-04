using System;
using System.Collections.Generic;

namespace ProyectoLibrary.Web.Models;

public partial class LibroModels
{
    public int LibroId { get; set; }

    public string Titulo { get; set; } = null!;

    public int? AutorId { get; set; }

    public int? CategoriaId { get; set; }

    public DateOnly? FechaPublicacion { get; set; }

    public decimal? Precio { get; set; }
}
