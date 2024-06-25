using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Domain.Models
{
    public class Categoria : Entidade
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public List<Lanche> Lanches { get; private set; }

        //public Categoria(string nome, string descricao)
        //{
        //    Nome = nome;
        //    Descricao = descricao;
        //    Lanches = new List<Lanche>();
        //}
    }
}
