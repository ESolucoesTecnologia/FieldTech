using System.ComponentModel.DataAnnotations;

namespace FieldTech.Application.Field.Dto
{
    public record EnderecoInputDto
    (
        string Logradouro,
        [Required(ErrorMessage = "Cidade não pode estar vazio")] string Cidade,
        [Required(ErrorMessage = "Estado não pode estar vazio")] string Estado,
        string Cep,
        string Complemento
    );
}
