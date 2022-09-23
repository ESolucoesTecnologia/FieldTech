using FieldTech.Application.Fornecedor.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.Fornecedor.Handler.Query
{
    public class GetAllFornecedorQueryResponse
    {
        public IEnumerable<FornecedorOutputDto> Fornecedor { get; set; }

        public GetAllFornecedorQueryResponse(IEnumerable<FornecedorOutputDto> fornecedor)
        {
            Fornecedor = fornecedor;
        }
    }
}
