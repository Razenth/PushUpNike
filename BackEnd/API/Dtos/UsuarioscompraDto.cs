using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos;
public class UsuarioscompraDto
{
    public int Id { get; set; }
    public int? UsuarioId { get; set; }

    public decimal TotalCompras { get; set; }

    public virtual Usuario Usuario { get; set; }
}