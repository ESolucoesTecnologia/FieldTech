using FluentValidation;
using System.Text.RegularExpressions;

namespace FieldTech.Domain.Field.Rules
{
    public class EmailValidator : AbstractValidator<ValueObjects.Email>
    {
        private const string Pattern = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        public EmailValidator()
        {
            RuleFor(x => x.Valor)
                .NotEmpty()
                .Must(BeAEmailValid).WithMessage("Email inválido");
        }

        private bool BeAEmailValid(string valor) => Regex.IsMatch(valor, Pattern);


    }
}
