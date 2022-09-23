using AutoMapper;
using FieldTech.Application.Fornecedor.Dto;
using FieldTech.Domain.Fornecedor.Repository;

namespace FieldTech.Application.Fornecedor.Service
{
    public class FornecedorService : IFornecedorService
    {

        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;
        public FornecedorService(IFornecedorRepository fornecedorRepository,
                                 IMapper mapper)
        {

            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;

        }

        public async Task<FornecedorOutputDto> Criar(FornecedorInputDto input)
        {
            var fornecedor = _mapper.Map<Domain.Fornecedor.Fornecedor>(input);
            await _fornecedorRepository.Save(fornecedor);
            return _mapper.Map<FornecedorOutputDto>(fornecedor);
        }

        public async Task<List<FornecedorOutputDto>> ListarTodos()
        {
            var fornecedor = await _fornecedorRepository.GetAll();
            return _mapper.Map<List<FornecedorOutputDto>>(fornecedor);
        }
    }
}
