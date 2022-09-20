using FieldTech.Application.Field.Dto;
using MediatR;

namespace FieldTech.Application.Field.Handler.Command
{
    public class CreateTecnicoCommand : IRequest<CreateTecnicoCommandResponse>
    {
        public TecnicoInputDto Tecnico { get; set; }        

        public CreateTecnicoCommand(TecnicoInputDto tecnico)
        {
            Tecnico = tecnico;
        }
    }
}
