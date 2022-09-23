using FieldTech.Application.Fornecedor.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.Fornecedor.Profile
{
    public class FornecedorProfile : AutoMapper.Profile
    {
        public FornecedorProfile()
        {
            CreateMap<FornecedorInputDto, FieldTech.Domain.Fornecedor.Fornecedor>();
            CreateMap<FieldTech.Domain.Fornecedor.Fornecedor, FornecedorOutputDto>();
           
        }
    }
}
