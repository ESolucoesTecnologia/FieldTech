using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Domain.OrdemServico.Rules
{
    public  class OrdemValidator : AbstractValidator<Ordem>
    {
        public OrdemValidator()
        {
            RuleFor(x => x.Estado).NotEmpty().WithMessage("Estado não pode ser vazio");
            RuleFor(x => x.Cidade).NotEmpty().WithMessage("Cidade não pode ser vazio");
            RuleFor(x => x.Fornecedor).NotEmpty().WithMessage("Ordem tem que ter um fornecedor");
            RuleFor(x => x.Dt_Acionamento).NotEmpty().WithMessage("Informe a data do acionamento");



        }
    }
}
