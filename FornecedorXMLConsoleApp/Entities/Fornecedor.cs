﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornecedorXMLConsoleApp.Entities
{
    public class Fornecedor
    {
        private Guid _idFornecedor;
        private string _nome;
        private string _cnpj;
        private Endereco _endereco;
        private List<Produto> _produtos;


        public Fornecedor()
        {
            IdFornecedor = Guid.NewGuid();        
        }

        public Guid IdFornecedor { get => _idFornecedor; set => _idFornecedor = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Cnpj { get => _cnpj; set => _cnpj = value; }
        public Endereco Endereco { get => _endereco; set => _endereco = value; }
        public List<Produto> Produtos { get => _produtos; set => _produtos = value; }
    }
}
