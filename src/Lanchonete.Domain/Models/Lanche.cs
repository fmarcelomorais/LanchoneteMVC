using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Domain.Models
{
    public class Lanche : Entidade
    {
        public string Nome { get; private set; }
        public int  Preco { get; private set; }
        public string  DescricaoCurta { get; private set; }
        public string  DescricaoLonga { get; private set; }
        public string  ImagemUrl { get; private set; }
        public string ThumbnailUrl { get; private set; }
        public bool Preferido { get; private set; }
        public bool Disponivel { get; private set; }

        /*EF Core*/
        public Guid CategoriaId { get; private set; }
        public Categoria Categoria { get; private set; }

        public Lanche(string nome, int preco, string descricaoCurta, string descricaoLonga, string imagem, string thumbnail, Categoria categoria, bool preferido, bool disponivel)
        {
            Nome = nome;
            Preco = preco;
            DescricaoCurta = descricaoCurta;
            DescricaoLonga = descricaoLonga;
            ImagemUrl = imagem;
            ThumbnailUrl = thumbnail;
            Categoria = categoria;
            Preferido = preferido;
            Disponivel = disponivel;
            CategoriaId = categoria.Id;
        }
    }
}
