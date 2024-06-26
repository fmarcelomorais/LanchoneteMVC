using Lanchonete.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Application.Interfaces
{
    public interface ILancheService
    {
        Task<IEnumerable<LancheDTO>> RetornaLanches();
    }
}
