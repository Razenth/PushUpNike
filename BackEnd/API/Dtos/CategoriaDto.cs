using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Dtos;
public class CategoriaDto
{
    public int Id { get; set; }
    public string NombreCategoria { get; set; } = null!;

}