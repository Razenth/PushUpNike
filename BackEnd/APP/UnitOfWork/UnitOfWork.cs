using Domain.Entities;
using Domain.Interfaces;
namespace APP.Repositories;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly NikeContext _context;

    public UnitOfWork(NikeContext context)
    {
        _context = context;
    }

    private ICarrocompra _carrocompra;  //ICiudad _ciudad
    public ICarrocompra Carrocompras
    {
        get
        {
            if (_carrocompra == null)
            {
                _carrocompra = new CarrocompraRepository(_context);
            }
            return _carrocompra;
        }
    }

    private ICategoria _categoria;  //ICiudad _ciudad
    public ICategoria Categorias
    {
        get
        {
            if (_categoria == null)
            {
                _categoria = new CategoriaRepository(_context);
            }
            return _categoria;
        }
    }

    private IDetallescarrocompra _detallesCarroCompra;  //ICiudad _ciudad
    public IDetallescarrocompra Detallescarrocompras
    {
        get
        {
            if (_detallesCarroCompra == null)
            {
                _detallesCarroCompra = new DetallescarroRepository(_context);
            }
            return _detallesCarroCompra;
        }
    }

    private IDetallespedido _detallesPedido;  //ICiudad _ciudad
    public IDetallespedido Detallespedidos
    {
        get
        {
            if (_detallesPedido == null)
            {
                _detallesPedido = new DetallespedidoRepository(_context);
            }
            return _detallesPedido;
        }
    }

    private IDetallestransaccion _detallesTransaccion;  //ICiudad _ciudad
    public IDetallestransaccion Detallestransacciones
    {
        get
        {
            if (_detallesTransaccion == null)
            {
                _detallesTransaccion = new DetallestransaccionRepository(_context);
            }
            return _detallesTransaccion;
        }
    }

    private IInventario _inventario;  //ICiudad _ciudad
    public IInventario Inventarios
    {
        get
        {
            if (_inventario == null)
            {
                _inventario = new InventarioRepository(_context);
            }
            return _inventario;
        }
    }

    private IPedido _pedido;  //ICiudad _ciudad
    public IPedido Pedidos
    {
        get
        {
            if (_pedido == null)
            {
                _pedido = new PedidoRepository(_context);
            }
            return _pedido;
        }
    }

    private IProducto _producto;  //ICiudad _ciudad
    public IProducto Productos
    {
        get
        {
            if (_producto == null)
            {
                _producto = new ProductoRepository(_context);
            }
            return _producto;
        }
    }

    private IRoles _roles;  //ICiudad _ciudad
    public IRoles Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RolesRepository(_context);
            }
            return _roles;
        }
    }

    private ITransacciones _transacciones;  //ICiudad _ciudad
    public ITransacciones Transacciones
    {
        get
        {
            if (_transacciones == null)
            {
                _transacciones = new TransaccionesRepository(_context);
            }
            return _transacciones;
        }
    }

    private IUsuario _usuario;  //ICiudad _ciudad
    public IUsuario Usuarios
    {
        get
        {
            if (_usuario == null)
            {
                _usuario = new UsuarioRepository(_context);
            }
            return _usuario;
        }
    }
    private IUsuarioscompra _usuarioCompra;  //ICiudad _ciudad
    public IUsuarioscompra Usuarioscompras
    {
        get
        {
            if (_usuarioCompra == null)
            {
                _usuarioCompra = new UsuarioscompraRepository(_context);
            }
            return _usuarioCompra;
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}