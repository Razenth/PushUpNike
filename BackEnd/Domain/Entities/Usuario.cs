using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Usuario
{
    public int Id { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public int? RolId { get; set; }

    public virtual ICollection<Carrocompra> Carrocompras { get; set; } = new List<Carrocompra>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

    public virtual Roles Rol { get; set; }

    public virtual ICollection<Transacciones> Transacciones { get; set; } = new List<Transacciones>();

    public virtual ICollection<Usuarioscompra> Usuarioscompras { get; set; } = new List<Usuarioscompra>();
}
