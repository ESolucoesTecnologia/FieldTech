namespace FieldTech.Domain.Fornecedor.ValueObjects
{
    public class Email
    {
        public Email()
        {

        }

        public Email(string email)
        {
            this.Valor = email ?? throw new ArgumentNullException(nameof(email));
        }

        public string Valor { get; set; }
    }
}
