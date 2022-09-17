namespace FieldTech.Application.Field.Dto
{
    public class TecnicoOutputDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime Dt_Nascimento { get; set; }
        public string CpfCnpj { get; set; }
        public string Rg { get; set; }
        public string OrgaoEmissor { get; set; }
        public string EstadoCivil { get; set; }
        public IList<EnderecoOutputDto> EnderecoList { get; set; }
        public IList<TelefoneOutputDto> TelefoneList { get; set; }
        public IList<EmailOutputDto> EmailList { get; set; }





    }
}
