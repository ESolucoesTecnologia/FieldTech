using System.ComponentModel.DataAnnotations;

namespace FieldTech.Application.Fornecedor.Dto
{
    public  record FornecedorInputDto
    (
        [Required(ErrorMessage = "Informe CNPJ fornecedor")] string Cnpj,
        [Required(ErrorMessage = "Informe nome fornecedor")] string Nome,
        [Required(ErrorMessage = "Informe endereço fornecedor")] string Endereco,
        [Required(ErrorMessage = "Informe cidade fornecedor")] string Cidade,
        [Required(ErrorMessage = "Informe Estado fornecedor")] string Estado,
        [Required(ErrorMessage = "Informe telefone fornecedor")] string Telefone,
        [Required(ErrorMessage = "Informe e-mail fornecedor")] string Email


        );






        
}
