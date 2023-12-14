﻿using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Inventario
{
    public int Id { get; set; }

    public int? ProductoId { get; set; }

    public int CantidadAnterior { get; set; }

    public int CantidadNueva { get; set; }

    public DateTime? FechaMovimiento { get; set; }

    public virtual Producto Producto { get; set; }
}
