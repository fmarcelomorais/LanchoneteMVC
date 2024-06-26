using Lanchonete.Application.DTOs;

namespace Lanchonete.UI.Models
{
    public class ListaLanches
    {
        public IEnumerable<LancheDTO> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
        
    }
}