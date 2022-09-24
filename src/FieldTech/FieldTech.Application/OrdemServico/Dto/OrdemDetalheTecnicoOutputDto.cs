using FieldTech.Application.Field.Dto;

namespace FieldTech.Application.OrdemServico.Dto
{
    public  class OrdemDetalheTecnicoOutputDto
    {

        public Guid Id { get; set; }
        public double Vl_Atividade  {get; set;}
        public double? Qtd_Km {get; set;}
        public double? Vl_Km {get; set;}
        public double? Vl_Pedagio {get; set;}
        public double? Vl_Material {get; set;}
        public double? Vl_Hospedagem {get; set;}
        public double? Qtd_HoraExcedente {get; set;}
        public double? Vl_HoraExcedente {get; set;}
        public DateTime Dt_HoraInicioAtividade {get; set;}
        public DateTime? Dt_HoraFimAtividade {get; set;}
        public TecnicoOutputDto TecnicoOuputDto { get; set; }

    }
}
