using FieldTech.CrossCutting.Entity;

namespace FieldTech.Domain.Field
{
    public class Email : Entity<Guid>
    {
        public ValueObjects.Email Endereco { get; set; }


    }
}
