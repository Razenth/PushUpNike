using Domain.Entities;
using Domain.Interfaces;

namespace APP.Repositories;
public class RolesRepository : GenericRepository<Roles>, IRoles
{
    private readonly NikeContext _context;
    public RolesRepository(NikeContext context) : base(context)
    {
        _context = context;
    }
}