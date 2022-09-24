using FieldTech.Application.Field.Dto;
using FieldTech.Domain.Field;

namespace FieldTech.Application.Field.Profile
{
    public class FieldProfile : AutoMapper.Profile
    {
        public FieldProfile()
        {

            CreateMap<EmailInputDto, Email>()
              .ForPath(x => x.Endereco.Valor, f => f.MapFrom(m => m.Email));

            CreateMap<Email, EmailOutputDto>()
                .ForMember(x => x.Email, f => f.MapFrom(m => m.Endereco.Valor));

            CreateMap<EnderecoInputDto, FieldTech.Domain.Field.Endereco>();
            CreateMap<FieldTech.Domain.Field.Endereco, EnderecoOutputDto>();

            CreateMap<TecnicoInputDto, Tecnico>()
                .ForMember(dest => dest.EnderecoList, opt => opt.MapFrom(src => src.EnderecoInputs))
                .ForMember(dest => dest.EmailList, opt => opt.MapFrom(src => src.EmailInputs))
                .ForMember(dest => dest.TelefoneList, opt => opt.MapFrom(src => src.TelefoneInputs));            



            CreateMap<Tecnico,TecnicoOutputDto>()
                .ForMember(dest => dest.EnderecoOutputs, opt => opt.MapFrom(src => src.EnderecoList))
                .ForMember(dest => dest.EmailOutputs, opt => opt.MapFrom(src => src.EmailList))
                .ForMember(dest => dest.TelefoneOutputs, opt => opt.MapFrom(src => src.TelefoneList)); 

            CreateMap<TelefoneInputDto, Telefone>()
                .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Telefone));
            CreateMap<Telefone, TelefoneInputDto>()
                .ForMember(dest => dest.Telefone, opt => opt.MapFrom(src => src.Numero));
            
            
            
        }
    }
}
