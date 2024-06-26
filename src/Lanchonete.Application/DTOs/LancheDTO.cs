using Lanchonete.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Application.DTOs
{
    public class LancheDTO
    {
        public Guid Id { get; set;}
        public string Nome { get; set; }
        public int Preco { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoLonga { get;  set; }
        public string ImagemUrl { get; set; }
        public string ThumbnailUrl { get;  set; }
        public bool Preferido { get;  set; }
        public bool Disponivel { get;  set; }

        public Categoria Categoria { get;  set; }
    }
}
