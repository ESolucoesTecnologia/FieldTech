using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.OrdemServico.Dto
{
    public record OrdemInputDto
    (
       [Required(ErrorMessage = "Informe o escopo")] string Escopo, 
       [Required(ErrorMessage = "Informe o projeto")]string Projeto, 
       [Required(ErrorMessage = "Informe o endereço")]string Endereco, 
       [Required(ErrorMessage = "Informe a cidade")]string Cidade, 
       [Required(ErrorMessage = "Informe o estado")]string Estado, 
       DateTime Dt_Acionamento, 
       DateTime Dt_Agendamento,        
       IList<OrdemDetalheInputDto>? OrdemDetalheInputList,
       [Required(ErrorMessage = "Informe o fornecedor")] Guid Fornecedor
    );
}
