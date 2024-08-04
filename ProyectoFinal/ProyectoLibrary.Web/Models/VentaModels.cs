using System;
using System.Collections.Generic;

namespace ProyectoLibrary.Web.Models;

public partial class VentaModels
{
    public int VentaId { get; set; }

    public int? LibroId { get; set; }

    public DateOnly FechaVenta { get; set; }

    public int Cantidad { get; set; }

    public decimal Total { get; set; }
}
