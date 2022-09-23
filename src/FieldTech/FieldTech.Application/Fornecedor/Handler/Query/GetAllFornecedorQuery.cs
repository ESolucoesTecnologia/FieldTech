using MediatR;

namespace FieldTech.Application.Fornecedor.Handler.Query
{
    public class GetAllFornecedorQuery : IRequest<GetAllFornecedorQueryResponse>
    {
        public string Fornecedor { get; set; }

        public GetAllFornecedorQuery()
        { }
        public GetAllFornecedorQuery(string fornecedor)
        {
            Fornecedor = fornecedor;
        }
    }
}
