using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Dtos;
public class TransaccionesDto
{
    public int Id { get; set; }
    public int? UsuarioId { get; set; }

    public DateTime? FechaTransaccion { get; set; }

    public decimal Total { get; set; }
}
