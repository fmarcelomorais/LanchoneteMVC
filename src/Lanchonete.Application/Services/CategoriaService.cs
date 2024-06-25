using AutoMapper;
using Lanchonete.Application.DTOs;
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
        private readonly IMapper _mapper;
        public CategoriaService(ICategoriaRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CategoriaDTO>> RetornaCategorias()
        {            
            return _mapper.Map<List<CategoriaDTO>>( await _service.GetAll());
        }
    }
}
