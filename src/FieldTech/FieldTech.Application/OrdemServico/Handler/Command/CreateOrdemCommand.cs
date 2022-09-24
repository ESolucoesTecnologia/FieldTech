using FieldTech.Application.OrdemServico.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.OrdemServico.Handler.Command
{
    public class CreateOrdemCommand : IRequest<CreateOrdemCommandResponse>
    {
        public OrdemInputDto Ordem { get; set; }

        public CreateOrdemCommand(OrdemInputDto ordem)
        {
            Ordem = ordem;
        }
    }
}
