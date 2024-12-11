﻿using System;
using System.Collections.Generic;

namespace GOLDENVFV.Models;

public partial class Habitacione
{
    public int IdHabitacion { get; set; }

    public int? IdTipoHabitacion { get; set; }

    public string? NombreHabitacion { get; set; }

    public bool? Estado { get; set; }

    public string? Descripcion { get; set; }

    public decimal? Costo { get; set; }

    public virtual TipoHabitacione? IdTipoHabitacionNavigation { get; set; }

    public virtual ICollection<ImagenHabitacion> ImagenHabitacions { get; set; } = new List<ImagenHabitacion>();

    public virtual ICollection<Paquete> Paquetes { get; set; } = new List<Paquete>();
}
