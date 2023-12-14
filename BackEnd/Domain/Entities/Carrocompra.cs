﻿using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Carrocompra
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<Detallescarrocompra> Detallescarrocompras { get; set; } = new List<Detallescarrocompra>();

    public virtual Usuario Usuario { get; set; }
}
