using System;
using System.Collections.Generic;

namespace ProyectoLibrary.Web.Models;

public partial class AutoreModels
{
    public int AutorId { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public DateOnly? FechaNacimiento { get; set; }

    public string? Nacionalidad { get; set; }
}
