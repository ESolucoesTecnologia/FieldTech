using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.OrdemServico.Dto
{
    public  class OrdemDetalheOutputDto
    {

        public Guid Id { get; set; }
        public double Vl_Atividade {get; set;}
        public double? Qtd_Km {get; set;}
        public double? Vl_Km {get; set;}
        public double? Vl_Pedagio {get; set;}
        public double? Vl_Material {get; set;}
        public double? Vl_Hospedagem {get; set;}
        public double? Qtd_HoraExcedente {get; set;}
        public double? Vl_HoraExcedente {get; set;}
        public DateTime Dt_HoraInicioAtividade {get; set;}
        public DateTime? Dt_HoraFimAtividade {get; set;}
        public IList<OrdemDetalheTecnicoOutputDto>? OrdemDetalheTecnicoOutputList { get; set; }

    }
}
