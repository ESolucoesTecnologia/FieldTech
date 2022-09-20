using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
