using Domain.Entities;
using Domain.Interfaces;

namespace APP.Repositories;
public class UsuarioscompraRepository : GenericRepository<Usuarioscompra>, IUsuarioscompra
{
    private readonly NikeContext _context;
    public UsuarioscompraRepository(NikeContext context) : base(context)
    {
        _context = context;
    }
}