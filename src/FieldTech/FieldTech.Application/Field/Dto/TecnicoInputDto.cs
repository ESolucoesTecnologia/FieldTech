using System.ComponentModel.DataAnnotations;

namespace FieldTech.Application.Field.Dto
{
    public record TecnicoInputDto
    (
        [Required(ErrorMessage ="Nome do técnico não pode estar vazio")] string Nome,
        [Required(ErrorMessage ="Data de Nascimento não pode estar vazio")] DateTime Dt_Nascimento,
        string CpfCnpj,
        string Rg,
        string OrgaoEmissor,
        string EstadoCivil,
        IList<TelefoneInputDto> TelefoneInputs,
        IList<EnderecoInputDto> EnderecoInputs,
        IList<EmailInputDto> EmailInputs
    );
}
