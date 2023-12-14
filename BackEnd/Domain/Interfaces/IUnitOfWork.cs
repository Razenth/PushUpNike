namespace Domain.Interfaces;

public interface IUnitOfWork
{
    ICarrocompra Carrocompras { get; }
    ICategoria Categorias { get;}
    IDetallescarrocompra Detallescarrocompras { get;}
    IDetallespedido Detallespedidos { get;}
    IDetallestransaccion Detallestransacciones { get;}
    IInventario Inventarios { get;}
    IPedido Pedidos { get;}
    IProducto Productos { get;}
    IRoles Roles { get;}
    ITransacciones Transacciones { get;}
    IUsuario Usuarios { get;}
    IUsuarioscompra Usuarioscompras { get;}
    Task<int> SaveAsync();
}