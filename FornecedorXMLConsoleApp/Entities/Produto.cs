using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornecedorXMLConsoleApp.Entities
{
    public class Produto
    {
        private Guid _idProduto;
        private string _nome;
        private int _quantidade;
        private decimal _preco;

        public Produto()
        {
            IdProduto = Guid.NewGuid();
        }
        public Guid IdProduto { get => _idProduto; set => _idProduto = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public decimal Preco { get => _preco; set => _preco = value; }
    }
}
