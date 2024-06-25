using Lanchonete.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Application.Interfaces
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> RetornaCategorias();
    }
}
