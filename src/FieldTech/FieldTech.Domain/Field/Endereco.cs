using FieldTech.CrossCutting.Entity;

namespace FieldTech.Domain.Field
{
    public class Endereco : Entity<Guid>
    {
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public DateTime Dt_Inclusao { get; set; }
        public DateTime Dt_Atualizacao { get; set; }

    }
}
