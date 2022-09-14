using FieldTech.CrossCutting.Entity;

namespace FieldTech.Domain.Field
{
    public class Tecnico : Entity<Guid>
    {
        public string Nome { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public string CpfCnpj { get; set; }
        public string Rg { get; set; }  
        public string OrgaoEmissor { get; set; }                
        public string EstadoCivil { get; set; }
        public virtual IList<Endereco> EnderecoList { get; set; }
        public virtual IList<Telefone> TelefoneList { get; set; }  
        public virtual IList<Email> EmailList { get; set; } 


    }
}
