using FieldTech.Application.Field.Handler.Command;
using FieldTech.Application.Field.Handler.Query;
using FieldTech.Application.Field.Service;
using MediatR;

namespace FieldTech.Application.Field.Handler
{
    public class TecnicoHandler :   IRequestHandler<CreateTecnicoCommand, CreateTecnicoCommandResponse>, 
                                    IRequestHandler<GetAllTecnicoQuery, GetAllTecnicoQueryResponse>
    {
        private readonly ITecnicoService _tecnicoService;

        public TecnicoHandler(ITecnicoService tecnicoService)
        {
            _tecnicoService = tecnicoService;
        }

        public async Task<GetAllTecnicoQueryResponse> Handle(GetAllTecnicoQuery request, CancellationToken cancellationToken)
        {
            var result = await this._tecnicoService.ListarTodos();
            return new GetAllTecnicoQueryResponse(result);

        }

        public async Task<CreateTecnicoCommandResponse> Handle(CreateTecnicoCommand request, CancellationToken cancellationToken)
        {
            var result = await this._tecnicoService.Criar(request.Tecnico);
            return new CreateTecnicoCommandResponse(result);    
        }
    }
}
