using FieldTech.Application.Field.Dto;

namespace FieldTech.Application.Field.Handler.Query
{
    public class GetAllTecnicoQueryResponse
    {
        public IEnumerable<TecnicoOutputDto> Tecnicos { get; set; }

        public GetAllTecnicoQueryResponse (IEnumerable<TecnicoOutputDto> tecnicos)
        {
            Tecnicos = tecnicos;
        }
    }
}
