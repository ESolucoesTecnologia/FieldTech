namespace FieldTech.Application.Field.Dto
{
    public class EnderecoOutputDto
    {
        public Guid Id { get; set; }
        public string Logradouro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }


    }
}
