using FieldTech.Application.Fornecedor.Dto;

namespace FieldTech.Application.Fornecedor.Service
{
    public interface IFornecedorService
    {
        Task<FornecedorOutputDto> Criar(FornecedorInputDto input);
        Task<List<FornecedorOutputDto>> ListarTodos();
    }
}
