using System;
using System.Collections.Generic;

namespace ProyectoLibrary.Web.Models;

public partial class VentaModel
{
    public int Id { get; set; }

    public int LibroId { get; set; }

    public DateOnly FechaVenta { get; set; }

    public int Cantidad { get; set; }

    public decimal Total { get; set; }

    public virtual Libro Libro { get; set; } = null!;
}
