using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Dtos;
public class PedidoDto
{
    public int Id { get; set; }
    public int? UsuarioId { get; set; }

    public DateOnly FechaPedido { get; set; }
    public string EstadoPedido { get; set; } = null!;
}