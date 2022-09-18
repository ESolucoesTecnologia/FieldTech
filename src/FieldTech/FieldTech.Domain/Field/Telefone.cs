using FieldTech.CrossCutting.Entity;

namespace FieldTech.Domain.Field
{
    public class Telefone : Entity<Guid>
    {
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public DateTime Dt_Inclusao { get; set; }
        public DateTime Dt_Atualizacao { get; set; }

    }
}
