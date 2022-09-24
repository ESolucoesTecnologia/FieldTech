using FieldTech.CrossCutting.Entity;
using FieldTech.Domain.Field.Rules;
using FluentValidation;

namespace FieldTech.Domain.Field
{
    public class Email : Entity<Guid>
    {
        public ValueObjects.Email Endereco { get; set; }
        public DateTime Dt_Inclusao { get; set; }
        public DateTime Dt_Atualizacao { get; set; }


      
    }
}
