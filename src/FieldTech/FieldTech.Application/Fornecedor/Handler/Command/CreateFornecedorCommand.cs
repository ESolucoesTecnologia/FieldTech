using FieldTech.Application.Fornecedor.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.Fornecedor.Handler.Command
{
    public class CreateFornecedorCommand : IRequest<CreateFornecedorCommandResponse>
    {
        public FornecedorInputDto Fornecedor { get; set; }

        public CreateFornecedorCommand(FornecedorInputDto fornecedor)
        {
            Fornecedor = fornecedor;
        }
    }
}
