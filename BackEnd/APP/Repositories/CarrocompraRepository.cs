using Domain.Entities;
using Domain.Interfaces;

namespace APP.Repositories;
public class CarrocompraRepository : GenericRepository<Carrocompra>, ICarrocompra
{
     private readonly NikeContext _context;
     public CarrocompraRepository(NikeContext context) : base(context)
     {
         _context = context;
     }
}