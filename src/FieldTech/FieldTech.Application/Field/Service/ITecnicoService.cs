using FieldTech.Application.Field.Dto;

namespace FieldTech.Application.Field.Service
{
    public interface ITecnicoService
    {
        Task<TecnicoOutputDto> Criar(TecnicoInputDto input);
        Task<List<TecnicoOutputDto>> ListarTodos();

    }
}
