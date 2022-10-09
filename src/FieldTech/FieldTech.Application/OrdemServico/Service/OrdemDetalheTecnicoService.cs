using AutoMapper;
using FieldTech.Application.OrdemServico.Dto;
using FieldTech.Domain.OrdemServico;
using FieldTech.Domain.OrdemServico.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.OrdemServico.Service
{
    public class OrdemDetalheTecnicoService : IOrdemDetalheTecnicoService
    {
        private readonly IOrdemDetalheTecnicoRepository _ordemDetalheTecnicoRepository;
        private readonly IMapper _mapper;

        public OrdemDetalheTecnicoService(IOrdemDetalheTecnicoRepository ordemDetalheTecnicoRepository, IMapper mapper)
        {
            _ordemDetalheTecnicoRepository = ordemDetalheTecnicoRepository;
            _mapper = mapper;
        }

        public async Task<OrdemDetalheTecnicoOutputDto> Criar(OrdemDetalheTecnicoInputDto ordemDetalheTecnicoInputDto)
        {
            var ordemDetalheTecnico = _mapper.Map<OrdemDetalheTecnico>(ordemDetalheTecnicoInputDto);
            await _ordemDetalheTecnicoRepository.Save(ordemDetalheTecnico);
            return _mapper.Map<OrdemDetalheTecnicoOutputDto>(ordemDetalheTecnico);
            
        }
    }
}
