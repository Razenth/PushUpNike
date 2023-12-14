using Domain.Entities;
using Domain.Interfaces;

namespace APP.Repositories;

public class InventarioRepository : GenericRepository<Inventario>, IInventario
{
    private readonly NikeContext _context;
    public InventarioRepository(NikeContext context) : base(context)
    {
        _context = context;
    }
}