using FieldTech.CrossCutting.Entity;

namespace FieldTech.Domain.Field
{
    public class Telefone : Entity<Guid>
    {
        public string Ddd { get; set; }
        public string Numero { get; set; }

    }
}
