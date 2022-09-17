using System.ComponentModel.DataAnnotations;

namespace FieldTech.Application.Field.Dto
{
    public record TelefoneInputDto
    (
        [Required(ErrorMessage="Ddd não pode ser vazio")] string Ddd,
        [Required(ErrorMessage="Telefone não pode ser vazio")] string Telefone        
    );
}
