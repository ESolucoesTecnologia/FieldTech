using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.OrdemServico.Handler.Query
{
    public  class GetIdOrdemQuery : IRequest<GetIdOrdemQueryResponse>
    {
        public GetIdOrdemQuery( Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

    }
}
