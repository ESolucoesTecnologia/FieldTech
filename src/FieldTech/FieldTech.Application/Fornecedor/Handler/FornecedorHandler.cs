using FieldTech.Application.Fornecedor.Handler.Command;
using FieldTech.Application.Fornecedor.Handler.Query;
using FieldTech.Application.Fornecedor.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.Fornecedor.Handler
{
    public class FornecedorHandler : IRequestHandler<CreateFornecedorCommand, CreateFornecedorCommandResponse>,
                                     IRequestHandler<GetAllFornecedorQuery, GetAllFornecedorQueryResponse>
    {

        private readonly IFornecedorService _fornecedorService;
        
        public FornecedorHandler(IFornecedorService fornecedor)
        {
            _fornecedorService = fornecedor;
        }

        public async Task<CreateFornecedorCommandResponse> Handle(CreateFornecedorCommand request, CancellationToken cancellationToken)
        {
            var result = await this._fornecedorService.Criar(request.Fornecedor);
            return new CreateFornecedorCommandResponse(result);
        }

        public async Task<GetAllFornecedorQueryResponse> Handle(GetAllFornecedorQuery request, CancellationToken cancellationToken)
        {
            var result = await this._fornecedorService.ListarTodos();
            return new GetAllFornecedorQueryResponse(result);
        }
    }
}
