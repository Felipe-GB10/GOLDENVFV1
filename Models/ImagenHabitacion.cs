﻿using System;
using System.Collections.Generic;

namespace GOLDENVFV.Models;

public partial class ImagenHabitacion
{
    public int IdImagenHabi { get; set; }

    public int? IdImagen { get; set; }

    public int? IdHabitacion { get; set; }

    public virtual Habitacione? IdHabitacionNavigation { get; set; }

    public virtual Imagene? IdImagenNavigation { get; set; }
}
