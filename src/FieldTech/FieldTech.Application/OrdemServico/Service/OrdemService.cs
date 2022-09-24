using AutoMapper;
using FieldTech.Application.OrdemServico.Dto;
using FieldTech.Domain.Fornecedor.Repository;
using FieldTech.Domain.OrdemServico;
using FieldTech.Domain.OrdemServico.Repository;

namespace FieldTech.Application.OrdemServico.Service
{
    public class OrdemService : IOrdemService
    {

        private readonly IOrdemRepository _ordemRepository;
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public OrdemService(IOrdemRepository ordemRepository,
                            IMapper mapper,
                            IFornecedorRepository fornecedorRepository)
        {
            _ordemRepository = ordemRepository;
            _mapper = mapper;
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task<OrdemOutputDto> Criar(OrdemInputDto input)
        {
            var ordem = _mapper.Map<Ordem>(input);
            ordem.Fornecedor =await  _fornecedorRepository.Get((Guid)input.FornecedorId);
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
