using FieldTech.CrossCutting.Entity;

namespace FieldTech.Domain.OrdemServico
{
    public class OrdemDetalhe : Entity<Guid>
    {
        public double Vl_Atividade { get; set; }
        public double Qtd_Km { get; set; }
        public double Vl_Km { get; set; }
        public double Vl_Pedagio { get; set; }
        public double Vl_Material { get; set; }
        public double Vl_Hospedagem { get; set; }
        public double Qtd_HoraExcedente { get; set; }
        public double Vl_HoraExcedente { get; set; }
        public DateTime Dt_HoraInicioAtividade { get; set; }
        public DateTime Dt_HoraFimAtividade { get; set; }
        public DateTime Dt_Inclusao { get; set; }
        public DateTime Dt_Atualizacao { get; set; }
        public virtual IList<OrdemDetalheTecnico> OrdemDetalheTecnicoList { get; set; }

    }
}
