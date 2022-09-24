using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Domain.OrdemServico.Rules
{
    public class OrdemDetalheValidator : AbstractValidator<OrdemDetalhe>
    {
        public OrdemDetalheValidator()
        {

            RuleFor(x => x.Dt_HoraInicioAtividade)
                .NotNull()
                .NotEmpty()                
                .WithMessage("Verifique a data de inicio da atividade");
            
        }

       

    }
}
