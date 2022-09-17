using FieldTech.Application.Field.Dto;
using FieldTech.Domain.Field;

namespace FieldTech.Application.Field.Profile
{
    public class FieldProfile : AutoMapper.Profile
    {
        public FieldProfile()
        {
            CreateMap<TecnicoInputDto, Tecnico>();
            CreateMap<Tecnico,TecnicoOutputDto>();
            CreateMap<TelefoneInputDto, Telefone>();
            CreateMap<Telefone, TelefoneInputDto>();
            CreateMap<EmailInputDto,Email>();
            CreateMap<Email, EmailOutputDto>();
            CreateMap<EnderecoInputDto, Endereco>();
            CreateMap<Endereco, EnderecoOutputDto>();            
        }
    }
}
