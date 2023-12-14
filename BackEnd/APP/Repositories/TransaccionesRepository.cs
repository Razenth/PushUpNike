using Domain.Entities;
using Domain.Interfaces;

namespace APP.Repositories;
public class TransaccionesRepository : GenericRepository<Transacciones>, ITransacciones
{
    private readonly NikeContext _context;
    public TransaccionesRepository(NikeContext context) : base(context)
    {
        _context = context;
    }
}