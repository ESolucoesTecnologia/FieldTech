using FieldTech.Application.Field.Dto;
using FieldTech.Domain.Field;

namespace FieldTech.Application.Field.Profile
{
    public class FieldProfile : AutoMapper.Profile
    {
        public FieldProfile()
        {
            CreateMap<TecnicoInputDto, Tecnico>()
                .ForMember(dest => dest.EnderecoList, opt => opt.MapFrom(src => src.EnderecoInputs))
                .ForMember(dest => dest.EmailList, opt => opt.MapFrom(src => src.EmailInputs))
                .ForMember(dest => dest.TelefoneList, opt => opt.MapFrom(src => src.TelefoneInputs));            



            CreateMap<Tecnico,TecnicoOutputDto>()
                .ForMember(dest => dest.EnderecoOutputs, opt => opt.MapFrom(src => src.EnderecoList))
                .ForMember(dest => dest.EmailOutputs, opt => opt.MapFrom(src => src.EmailList))
                .ForMember(dest => dest.TelefoneOutputs, opt => opt.MapFrom(src => src.TelefoneList)); 

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
