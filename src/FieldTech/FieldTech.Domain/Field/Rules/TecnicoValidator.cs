using FluentValidation;

namespace FieldTech.Domain.Field.Rules
{
    public class TecnicoValidator : AbstractValidator<Tecnico>
    {
        public TecnicoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.EmailList)
                .Must(x => x.Count == 0).WithMessage("E-Mail não informado.");
            RuleFor(x => x.TelefoneList)
                .Must(x => x.Count == 0).WithMessage("Telefone não informado.");
            RuleFor(x => x.EnderecoList)
                .Must(x => x.Count == 0).WithMessage("Endereço não informado.");
        }
    }
}
