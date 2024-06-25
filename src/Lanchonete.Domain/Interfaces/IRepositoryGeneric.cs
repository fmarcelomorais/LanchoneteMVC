using Lanchonete.Domain.Models;

namespace Lanchonete.Domain.Interafces
{
    public interface IRepositoryGeneric<TEntity> where TEntity : Entidade
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(Guid id);
        Task<bool> Post(TEntity categoria);
        Task<bool> Put(TEntity categoria);
        Task<bool> Delete(Guid id);
    }
}
