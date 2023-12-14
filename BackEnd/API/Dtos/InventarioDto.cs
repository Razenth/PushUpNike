using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos;
public class InventarioDto
{
    public int Id { get; set; }

    public int? ProductoId { get; set; }

    public int CantidadAnterior { get; set; }

    public int CantidadNueva { get; set; }

    public DateTime? FechaMovimiento { get; set; }

    public virtual Producto Producto { get; set; }
}