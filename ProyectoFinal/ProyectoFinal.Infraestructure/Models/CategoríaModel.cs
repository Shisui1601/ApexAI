using System;
using System.Collections.Generic;

namespace ProyectoLibrary.Web.Models;

public partial class CategoríaModel
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
