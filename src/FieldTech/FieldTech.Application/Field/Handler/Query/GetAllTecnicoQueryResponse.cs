using FieldTech.Application.Field.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
