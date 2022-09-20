using FieldTech.Application.Field.Dto;

namespace FieldTech.Application.Field.Handler.Command
{

    public class CreateTecnicoCommandResponse
    {
        public TecnicoOutputDto Tecnico { get; set; }

        public CreateTecnicoCommandResponse(TecnicoOutputDto tecnico)
        {
            Tecnico = tecnico;
        }
    }
}
