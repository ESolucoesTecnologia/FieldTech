using FieldTech.CrossCutting.Entity;

namespace FieldTech.Domain.OrdemServico
{
    public class Ordem : Entity<Guid>
    {
        public string Escopo { get; set; }
        public string Projeto { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime Dt_Acionamento { get; set; }
        public DateTime Dt_Agendamento { get; set; }
        public DateTime Dt_Inclusao { get; set; }
        public DateTime Dt_Atualizacao { get; set; }
        public virtual IList<OrdemDetalhe>? OrdemDetalheList { get; set; } 
        public virtual Fornecedor.Fornecedor Fornecedor { get; set; }
    }
}
