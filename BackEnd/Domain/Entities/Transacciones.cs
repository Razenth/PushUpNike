using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Transacciones
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? FechaTransaccion { get; set; }

    public decimal Total { get; set; }

    public virtual ICollection<Detallestransaccion> Detallestransaccions { get; set; } = new List<Detallestransaccion>();

    public virtual Usuario Usuario { get; set; }
}
