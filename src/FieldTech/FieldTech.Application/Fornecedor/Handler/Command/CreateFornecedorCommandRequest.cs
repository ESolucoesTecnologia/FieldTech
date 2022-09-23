using FieldTech.Application.Fornecedor.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.Fornecedor.Handler.Command
{
    public class CreateFornecedorCommandResponse
    {
        public FornecedorOutputDto Fornecedor { get; set; }

        public CreateFornecedorCommandResponse(FornecedorOutputDto fornecedor)
        {
            Fornecedor = fornecedor;
        }
    }
}
