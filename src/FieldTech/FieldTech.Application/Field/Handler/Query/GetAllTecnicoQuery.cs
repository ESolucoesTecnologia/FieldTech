using MediatR;

namespace FieldTech.Application.Field.Handler.Query
{
    public class GetAllTecnicoQuery : IRequest<GetAllTecnicoQueryResponse>
    {
        public string Tecnico { get; set; }

        public GetAllTecnicoQuery()
        { }
        public GetAllTecnicoQuery(string tecnico)
        {
            Tecnico = tecnico;
        }
    }
}
