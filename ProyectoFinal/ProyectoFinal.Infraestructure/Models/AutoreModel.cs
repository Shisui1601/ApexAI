using System;
using System.Collections.Generic;

namespace ProyectoLibrary.Web.Models;

public partial class AutoreModel
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Nacionalidad { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
