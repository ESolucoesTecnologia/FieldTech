using System.ComponentModel.DataAnnotations;

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
       [Required(ErrorMessage = "Informe o fornecedor")] Guid FornecedorId
    );
}
