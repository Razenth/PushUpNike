using Domain.Entities;
using Domain.Interfaces;

namespace APP.Repositories;
public class DetallespedidoRepository : GenericRepository<Detallespedido>, IDetallespedido
{
    private readonly NikeContext _context;
    public DetallespedidoRepository(NikeContext context) : base(context)
    {
        _context = context;
    }
}