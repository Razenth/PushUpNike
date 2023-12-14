using Domain.Entities;
using Domain.Interfaces;

namespace APP.Repositories;

public class DetallescarroRepository : GenericRepository<Detallescarrocompra>, IDetallescarrocompra
{
    private readonly NikeContext _context;
    public DetallescarroRepository(NikeContext context) : base(context)
    {
        _context = context;
    }
}