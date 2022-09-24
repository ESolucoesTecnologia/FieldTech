using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.OrdemServico.Handler.Query
{
    public class GetAllOrdemQuery : IRequest<GetAllOrdemQueryResponse>
    {
        public GetAllOrdemQuery()
        {
        }

        public string Ordem { get; set; }

        public GetAllOrdemQuery(string ordem)
        {
            Ordem = ordem;
        }

    }




}
