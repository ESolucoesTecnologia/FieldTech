using FieldTech.Application.OrdemServico.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.OrdemServico.Service
{
    public interface IOrdemDetalheService
    {
        Task<OrdemDetalheOutputDto> Criar(OrdemDetalheInputDto ordemDetalhe);


    }
}
