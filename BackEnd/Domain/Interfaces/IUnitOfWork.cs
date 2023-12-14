namespace Domain.Interfaces;

public interface IUnitOfWork
{
    ICarrocompra CarroICarrocompra { get; }
    Task<int> SaveAsync();
}