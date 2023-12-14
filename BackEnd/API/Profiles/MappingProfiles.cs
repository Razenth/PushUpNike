using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Carrocompra, CarrocompraDto>().ReverseMap(); //Entidad EntidadDto
        CreateMap<Categoria,CategoriaDto>().ReverseMap(); //Entidad EntidadDto
        CreateMap<Detallescarrocompra,DetallescarrocompraDto>().ReverseMap(); //Entidad EntidadDto
        CreateMap<Detallespedido,DetallespedidoDto>().ReverseMap(); //Entidad EntidadDto
        CreateMap<Detallestransaccion,DetallestransaccionDto>().ReverseMap(); //Entidad EntidadDto
        CreateMap<Inventario,InventarioDto>().ReverseMap(); //Entidad EntidadDto
        CreateMap<Pedido,PedidoDto>().ReverseMap(); //Entidad EntidadDto
        CreateMap<Producto,ProductoDto>().ReverseMap(); //Entidad EntidadDto
        CreateMap<Transacciones,TransaccionesDto>().ReverseMap(); //Entidad EntidadDto
        CreateMap<Usuario,UsuarioDto>().ReverseMap(); //Entidad EntidadDto
        CreateMap<Usuarioscompra,UsuarioscompraDto>().ReverseMap(); //Entidad EntidadDto
    }
}