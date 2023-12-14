using Domain.Interfaces;
namespace APP.Repositories;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly NikeContext _context;

    public UnitOfWork(NikeContext context)
    {
        _context = context;
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