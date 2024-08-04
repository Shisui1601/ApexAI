using System;
using System.Collections.Generic;

namespace ProyectoLibrary.Web.Models;

public partial class Libro
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public int AutorId { get; set; }

    public int CategoriaId { get; set; }

    public decimal Precio { get; set; }

    public DateOnly? FechaPublicacion { get; set; }

    public virtual AutoreModel Autor { get; set; } = null!;

    public virtual CategoríaModel Categoria { get; set; } = null!;

    public virtual ICollection<VentaModel> Venta { get; set; } = new List<VentaModel>();
}
