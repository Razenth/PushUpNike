using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Dtos;
public class DetallescarrocompraDto
{
    public int Id { get; set; }
    public int? CarroId { get; set; }
    public int? ProductoId { get; set; }
    public int Cantidad { get; set; }
}