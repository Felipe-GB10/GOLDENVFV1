﻿using System;
using System.Collections.Generic;

namespace GOLDENVFV.Models;

public partial class DetalleReservaPaquete
{
    public int DetalleReservaPaquete1 { get; set; }

    public int? IdPaquete { get; set; }

    public int? IdReserva { get; set; }

    public int? Cantidad { get; set; }

    public decimal? Costo { get; set; }

    public virtual Paquete? IdPaqueteNavigation { get; set; }

    public virtual Reserva? IdReservaNavigation { get; set; }
}
