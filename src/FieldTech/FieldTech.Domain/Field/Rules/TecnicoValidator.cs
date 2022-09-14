using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Domain.Field.Rules
{
    public class TecnicoValidator : AbstractValidator<Tecnico>
    {
        public TecnicoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.EmailList).NotEmpty();  
            RuleFor(x => x.TelefoneList).NotEmpty();    
            RuleFor(x => x.EnderecoList).NotEmpty();
        }
    }
}
