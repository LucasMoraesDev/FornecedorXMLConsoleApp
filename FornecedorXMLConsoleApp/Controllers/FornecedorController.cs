using FornecedorXMLConsoleApp.Entities;
using FornecedorXMLConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FornecedorXMLConsoleApp.Controller
{
    public class FornecedorController
    {
        public void CadastrarFornecedor()
        {
            try
            {
                Console.WriteLine("\n*** CADASTRO DE FORNECEDOR ***\n");

                var fornecedor = new Fornecedor();

                Console.Write("NOME DO FORNECEDOR......: ");
                fornecedor.Nome = Console.ReadLine();

                Console.Write("CNPJ DO FORNECEDOR......: ");
                fornecedor.Cnpj = Console.ReadLine();


                var endereco = new Endereco();
                Console.Write("LOGRADOURO..............: ");
                endereco.Logradouro = Console.ReadLine();

                Console.Write("BAIRRO..................: ");
                endereco.Bairro = Console.ReadLine();

                Console.Write("CIDADE..................: ");
                endereco.Cidade = Console.ReadLine();

                Console.Write("ESTADO..................: ");
                endereco.Estado = Console.ReadLine();

                Console.Write("CEP.....................: ");
                endereco.Cep = Console.ReadLine();


                fornecedor.Endereco = endereco;


                Console.Write("QTD DE PRODUTOS.........: ");
                var qtdProdutos = int.Parse(Console.ReadLine());

                if (qtdProdutos > 0)
                {
                    //inicializando a lista de produtos do fornecedor
                    //criando espaço em memória para usar a lista
                    fornecedor.Produtos = new List<Produto>();

                    for (int i = 1; i <= qtdProdutos; i++)
                    {
                        Console.WriteLine($"\nINFORME OS DADOS DO {i}º PRODUTO: ");

                        var produto = new Produto();

                        Console.Write("NOME DO PRODUTO.........: ");
                        produto.Nome = Console.ReadLine();

                        Console.Write("QUANTIDADE..............: ");
                        produto.Quantidade = int.Parse(Console.ReadLine());

                        Console.Write("PREÇO...................: ");
                        produto.Preco = decimal.Parse(Console.ReadLine());



                        //adicionar o produto dentro da lista
                        fornecedor.Produtos.Add(produto);
                    }

                }

                FornecedorRepositoryXML fornecedorRepository = new FornecedorRepositoryXML();

                //exportando o arquivo
                fornecedorRepository.Exportar(fornecedor);

                Console.WriteLine("\nFORNECEDOR CADASTRADO COM SUCESSO!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao cadastrar Fornecedor");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
