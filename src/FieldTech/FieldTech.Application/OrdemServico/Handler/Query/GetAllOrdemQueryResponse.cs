using FieldTech.Application.OrdemServico.Dto;

namespace FieldTech.Application.OrdemServico.Handler.Query
{
    public class GetAllOrdemQueryResponse
    {
        public GetAllOrdemQueryResponse(IEnumerable<OrdemOutputDto> ordem)
        {
            Ordem = ordem;
        }

        public IEnumerable<OrdemOutputDto> Ordem { get; set; }
    }

    

}
