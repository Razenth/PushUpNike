using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Pedido
{
    public int Id { get; set; }

    public int? UsuarioId { get; set; }

    public DateOnly FechaPedido { get; set; }

    public string EstadoPedido { get; set; } = null!;

    public virtual ICollection<Detallespedido> Detallespedidos { get; set; } = new List<Detallespedido>();

    public virtual Usuario Usuario { get; set; }
}
