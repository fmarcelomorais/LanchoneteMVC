using AutoMapper;
using Lanchonete.Application.DTOs;
using Lanchonete.Application.Interfaces;
using Lanchonete.Domain.Interafces;

namespace Lanchonete.Application.Services
{
    public class LancheService : ILancheService
    {
        private readonly ILanchesRepository _service;
        private readonly IMapper _mapper;
        public LancheService(ILanchesRepository service, IMapper mapper) 
        { 
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<LancheDTO>> RetornaLanches()
        {
            return _mapper.Map<List<LancheDTO>>(await _service.GetAll());
        }
    }
}
