using FieldTech.Application.OrdemServico.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.OrdemServico.Handler.Query
{
    public class GetIdOrdemQueryResponse
    {
        public GetIdOrdemQueryResponse(OrdemOutputDto ordem)
        {
            Ordem = ordem;
        }

        public OrdemOutputDto Ordem { get; set; }



    }
}
