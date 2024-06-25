using Lanchonete.Application.Interfaces;
using Lanchonete.Domain.Interafces;
using Lanchonete.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _service;
        public CategoriaService(ICategoriaRepository service)
        {
            _service = service;
        }
        public async Task<IEnumerable<Categoria>> RetornaCategorias()
        {
            return await _service.GetAll();
        }
    }
}
