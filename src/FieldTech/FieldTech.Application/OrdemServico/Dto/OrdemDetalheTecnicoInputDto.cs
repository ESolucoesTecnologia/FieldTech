using FieldTech.Application.Field.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.OrdemServico.Dto
{
    public record OrdemDetalheTecnicoInputDto
    (
        [Required(ErrorMessage = "Informe o valor da atividade")] double Vl_Atividade,
        double? Qtd_Km,
        double? Vl_Km,
        double? Vl_Pedagio,
        double? Vl_Material,
        double? Vl_Hospedagem,
        double? Qtd_HoraExcedente,
        double? Vl_HoraExcedente,
        [Required(ErrorMessage = "Informe a data de inicio da atividade")] DateTime Dt_HoraInicioAtividade,
        DateTime? Dt_HoraFimAtividade,
        Guid TecnicoId
    );
}
