using FieldTech.Application.Field.Dto;
using FieldTech.Domain.Field;

namespace FieldTech.Application.Field.Profile
{
    public class FieldProfile : AutoMapper.Profile
    {
        public FieldProfile()
        {
            CreateMap<TecnicoInputDto, FieldTech.Domain.Field.Tecnico>();
            CreateMap<FieldTech.Domain.Field.Tecnico,TecnicoOutputDto>();
            
            CreateMap<TelefoneInputDto, FieldTech.Domain.Field.Telefone>();
            CreateMap<FieldTech.Domain.Field.Telefone, TelefoneInputDto>();
            
            CreateMap<EmailInputDto,FieldTech.Domain.Field.Email>()
                .ForPath(x => x.Endereco.Valor, f=> f.MapFrom(m => m.Email));            
            CreateMap<FieldTech.Domain.Field.Email, EmailOutputDto>();
            
            CreateMap<EnderecoInputDto, FieldTech.Domain.Field.Endereco>();
            CreateMap<FieldTech.Domain.Field.Endereco, EnderecoOutputDto>();            
        }
    }
}
