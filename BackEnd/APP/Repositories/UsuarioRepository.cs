using Domain.Entities;
using Domain.Interfaces;

namespace APP.Repositories;
public class UsuarioRepository : GenericRepository<Usuario>, IUsuario
{
    private readonly NikeContext _context;
    public UsuarioRepository(NikeContext context) : base(context)
    {
        _context = context;
    }
}