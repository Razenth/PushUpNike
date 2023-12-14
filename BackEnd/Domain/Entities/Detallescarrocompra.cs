using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Detallescarrocompra : BaseEntity
{

    public int? CarroId { get; set; }

    public int? ProductoId { get; set; }

    public int Cantidad { get; set; }

    public virtual Carrocompra Carro { get; set; }

    public virtual Producto Producto { get; set; }
}
