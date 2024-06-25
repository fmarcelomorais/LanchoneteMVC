using Lanchonete.Domain.Interafces;
using Lanchonete.Domain.Models;
using Lanchonete.Infraestrutura.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Infraestrutura.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationContext _context;
        public CategoriaRepository(ApplicationContext context) { _context = context; }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            var categorias = await _context.Categorias.AsNoTracking().ToListAsync();
            return categorias;
        }
        public async Task<Categoria> Get(Guid id)
        {
            return await _context.Categorias.FirstOrDefaultAsync(cat => cat.Id == id);
        }
        public async Task<bool> Post(Categoria categoria)
        {
            await _context.Categorias.AddAsync(categoria);
            return await _context.SaveChangesAsync() == 1 ? true : false;
            
        }
        public async Task<bool> Delete(Guid id)
        {
            var categoria = await Get(id);
            _context.Categorias.Remove(categoria);
            return await _context.SaveChangesAsync() == 1 ? true : false;
        }
        public async Task<bool> Put(Categoria categoria)
        {
            _context.Entry<Categoria>(categoria).State = EntityState.Modified;
            return await _context.SaveChangesAsync() == 1 ? true : false;
        }
    }
}
