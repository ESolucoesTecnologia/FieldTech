using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
