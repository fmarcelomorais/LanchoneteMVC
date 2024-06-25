using Lanchonete.Domain.Models;

namespace Lanchonete.Domain.Interafces
{
    public interface ILanchesRepository : IRepositoryGeneric<Lanche>
    {
        Task<IEnumerable<Lanche>> LanhcesPreferidos();
    }
}
