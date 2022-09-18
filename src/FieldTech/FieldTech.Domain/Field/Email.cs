using FieldTech.CrossCutting.Entity;

namespace FieldTech.Domain.Field
{
    public class Email : Entity<Guid>
    {
        public ValueObjects.Email Endereco { get; set; }
        public DateTime Dt_Inclusao { get; set; }
        public DateTime Dt_Atualizacao { get; set; }


    }
}
