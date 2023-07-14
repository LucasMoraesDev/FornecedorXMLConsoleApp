using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornecedorXMLConsoleApp.Entities
{
    public class Endereco
    {
        private Guid _idEndereco;
        private string _logradouro;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _cep;

        public Endereco()
        {
            IdEndereco = Guid.NewGuid();
        }

        public Guid IdEndereco { get => _idEndereco; set => _idEndereco = value; }
        public string Logradouro { get => _logradouro; set => _logradouro = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Cep { get => _cep; set => _cep = value; }
    }
}
