using AutoMapper;
using FieldTech.Application.Field.Dto;
using FieldTech.Domain.Field;
using FieldTech.Domain.Field.Repository;

namespace FieldTech.Application.Field.Service
{
    public class TecnicoService : ITecnicoService
    {
        private readonly ITecnicoRepository _tecnicoRepository;
        private readonly IMapper _mapper;

        public TecnicoService(ITecnicoRepository tecnicoRepository,
                              IMapper mapper)
        {
            _tecnicoRepository = tecnicoRepository; 
             _mapper = mapper;
        }

        public async Task<TecnicoOutputDto> Criar(TecnicoInputDto input)
        {
            var tecnico = _mapper.Map<Tecnico>(input);
            await _tecnicoRepository.Save(tecnico);
            return _mapper.Map<TecnicoOutputDto>(tecnico);
        }

        public async Task<List<TecnicoOutputDto>> ListarTodos()
        {
            var tecnico = await _tecnicoRepository.GetAll();    
            return _mapper.Map<List<TecnicoOutputDto>>(tecnico);
        }
    }
}
