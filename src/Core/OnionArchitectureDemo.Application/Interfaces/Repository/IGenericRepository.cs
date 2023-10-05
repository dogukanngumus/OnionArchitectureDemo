using OnionArchitectureDemo.Domain.Common;

namespace OnionArchitectureDemo.Application.Interfaces.Repository;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task<T> AddAsync(T entity);
}