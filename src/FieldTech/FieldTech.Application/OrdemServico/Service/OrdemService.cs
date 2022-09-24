using AutoMapper;
using FieldTech.Application.OrdemServico.Dto;
using FieldTech.Domain.OrdemServico;
using FieldTech.Domain.OrdemServico.Repository;

namespace FieldTech.Application.OrdemServico.Service
{
    public class OrdemService : IOrdemService
    {

        private readonly IOrdemRepository _ordemRepository;
        private readonly IMapper _mapper;

        public OrdemService(IOrdemRepository ordemRepository,
                            IMapper mapper)
        {
            _ordemRepository = ordemRepository;
            _mapper = mapper;
        }

        public async Task<OrdemOutputDto> Criar(OrdemInputDto input)
        {
            var ordem = _mapper.Map<Ordem>(input);
            await _ordemRepository.Save(ordem);
            return _mapper.Map<OrdemOutputDto>(ordem);
        }

        public async Task<List<OrdemOutputDto>> ListarTodos()
        {
            var ordem = await _ordemRepository.GetAll();
            return _mapper.Map<List<OrdemOutputDto>>(ordem);
        }

        public async Task<OrdemOutputDto> ObterOrdem(Guid id)
        {
            var ordem = await _ordemRepository.ObterPorId(id);
            return _mapper.Map<OrdemOutputDto>(ordem);
        }
    }
}
