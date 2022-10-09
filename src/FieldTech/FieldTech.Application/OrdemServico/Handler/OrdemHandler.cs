using FieldTech.Application.OrdemServico.Handler.Command;
using FieldTech.Application.OrdemServico.Handler.Query;
using FieldTech.Application.OrdemServico.Service;
using MediatR;

namespace FieldTech.Application.OrdemServico.Handler
{
    public class OrdemHandler : IRequestHandler<CreateOrdemCommand, CreateOrdemCommandResponse>,
                                IRequestHandler<GetAllOrdemQuery, GetAllOrdemQueryResponse>,
                                IRequestHandler<GetIdOrdemQuery, GetIdOrdemQueryResponse>

    {

        private readonly IOrdemService _ordemService;

        public OrdemHandler(IOrdemService ordemService)
        {
            _ordemService = ordemService;
        }

        public async Task<CreateOrdemCommandResponse> Handle(CreateOrdemCommand request, CancellationToken cancellationToken)
        {
            var result = await this._ordemService.Criar(request.Ordem);
            return new CreateOrdemCommandResponse(result);
        }

        public async Task<GetAllOrdemQueryResponse> Handle(GetAllOrdemQuery request, CancellationToken cancellationToken)
        {
            var result = await this._ordemService.ListarTodos();
            return new GetAllOrdemQueryResponse(result);
        }

        public async Task<GetIdOrdemQueryResponse> Handle(GetIdOrdemQuery request, CancellationToken cancellationToken)
        {
            var result = await this._ordemService.ObterOrdem(request.Id);
            return new GetIdOrdemQueryResponse(result);
        }

        //public Task<CreateOrdemDetalheTecnicoCommandResponse> Handle(CreateOrdemDetalheTecnicoCommand request, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
