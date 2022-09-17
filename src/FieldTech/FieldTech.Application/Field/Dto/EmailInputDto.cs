using System.ComponentModel.DataAnnotations;

namespace FieldTech.Application.Field.Dto
{
    public record EmailInputDto
    (
        [Required(ErrorMessage="E-mail não pode ser vazio")] string Email
    );
}
