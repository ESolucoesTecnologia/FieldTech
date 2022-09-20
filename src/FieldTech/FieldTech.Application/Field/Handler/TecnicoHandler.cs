using FieldTech.Application.Field.Handler.Query;
using FieldTech.Application.Field.Service;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.Field.Handler
{
    public class TecnicoHandler : IRequestHandler<GetAllTecnicoQuery, GetAllTecnicoQueryResponse>
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
    }
}
