using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoLibrary.Domain.Entities;

public partial class Venta
{
    [Key]
    public int VentaId { get; set; }

    public int? LibroId { get; set; }

    public DateOnly FechaVenta { get; set; }

    public int Cantidad { get; set; }

    public decimal Total { get; set; }
}
