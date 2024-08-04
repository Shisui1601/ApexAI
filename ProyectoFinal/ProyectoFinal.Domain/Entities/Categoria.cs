using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoLibrary.Domain.Entities;

public partial class Categoria
{
    [Key]
    public int CategoriaId { get; set; }

    public string Nombre { get; set; } = null!;
}
