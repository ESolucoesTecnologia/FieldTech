using FieldTech.Application.OrdemServico.Dto;
using FieldTech.Domain.OrdemServico;

namespace FieldTech.Application.OrdemServico.Profile
{
    public class OrdemServicoProfile : AutoMapper.Profile
    {
        public OrdemServicoProfile()
        {
            CreateMap<OrdemInputDto, Ordem>()
                .ForMember(dest => dest.OrdemDetalheList, opt => opt.MapFrom(src => src.OrdemDetalheInputList));

                
            CreateMap<Ordem,OrdemOutputDto>()
                .ForMember(dest => dest.OrdemDetalheOutputList, opt => opt.MapFrom(src => src.OrdemDetalheList));


            CreateMap<OrdemDetalheInputDto, OrdemDetalhe>();

            CreateMap<OrdemDetalhe, OrdemDetalheOutputDto>()
                .ForMember(dest => dest.OrdemDetalheTecnicoOutputList, opt => opt.MapFrom(src => src.OrdemDetalheTecnicoList));


            CreateMap<OrdemDetalheTecnicoInputDto, OrdemDetalheTecnico>();
                

            CreateMap<OrdemDetalheTecnico, OrdemDetalheTecnicoOutputDto>()
                .ForMember(dest => dest.TecnicoOuputDto, opt => opt.MapFrom(src => src.Tecnico));




        }
    }
}
