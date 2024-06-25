using Lanchonete.Domain.Interafces;
using Lanchonete.Domain.Models;
using Lanchonete.Infraestrutura.Context;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete.Infraestrutura.Repositories
{
    public class LancheRepository : ILanchesRepository
    {
        private readonly ApplicationContext _context;
        public LancheRepository(ApplicationContext context) { _context = context; }
        public async Task<IEnumerable<Lanche>> GetAll()
        {
            var lanches = await _context.Lanches
                .AsNoTracking()
                .Include(cat => cat.Categoria)
                .ToListAsync();
            return lanches;
        }
        public async Task<Lanche> Get(Guid id)
        {
            return await _context.Lanches.FirstOrDefaultAsync(lan => lan.Id == id);
        }
        public async Task<bool> Post(Lanche lanche)
        {
            await _context.Lanches.AddAsync(lanche);
            return await _context.SaveChangesAsync() == 1 ? true : false;

        }
        public async Task<bool> Delete(Guid id)
        {
            var lanche = await Get(id);
            _context.Lanches.Remove(lanche);
            return await _context.SaveChangesAsync() == 1 ? true : false;
        }
        public async Task<bool> Put(Lanche lanche)
        {
            _context.Entry<Lanche>(lanche).State = EntityState.Modified;
            return await _context.SaveChangesAsync() == 1 ? true : false;
        }

        public async Task<IEnumerable<Lanche>> LanhcesPreferidos()
        {
            return _context.Lanches
                .OrderBy(l => l.Disponivel == true)
                .Where(lanche => lanche.Preferido == true)
                .Include(cat => cat.Categoria);
        }
    }
}
