using AutoMapper;
using FieldTech.Application.Field.Dto;
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

        public Task<TecnicoOutputDto> Criar(TecnicoInputDto input)
        {
            throw new NotImplementedException();
        }
    }
}
