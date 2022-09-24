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
    public class OrdemDetalheService : IOrdemDetalheService
    {
        private readonly IOrdemDetalheRepository _ordemDetalheRepository;
        private readonly IMapper _mapper;

        public OrdemDetalheService(IOrdemDetalheRepository ordemDetalheRepository, IMapper mapper)
        {
            _ordemDetalheRepository = ordemDetalheRepository;
            _mapper = mapper;
        }

        public async Task<OrdemDetalheOutputDto> Criar(OrdemDetalheInputDto input)
        {
            var ordemDetalhe = _mapper.Map<OrdemDetalhe>(input);
            await _ordemDetalheRepository.Save(ordemDetalhe);
            return _mapper.Map<OrdemDetalheOutputDto>(ordemDetalhe);
        }
    }
}
