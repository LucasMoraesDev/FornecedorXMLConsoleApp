using FornecedorXMLConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FornecedorXMLConsoleApp.Repositories
{
    public class FornecedorRepositoryXML
    {
        public void Exportar(Fornecedor fornecedor)
        {
            var xmlSerializer = new XmlSerializer(typeof(Fornecedor));

            var streamWriter = new StreamWriter("C:\\temp\\fornecedor.xml");

            xmlSerializer.Serialize(streamWriter, fornecedor);

            streamWriter.Close();
        }
    }
}
