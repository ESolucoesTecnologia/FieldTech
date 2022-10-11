namespace FieldTech.Domain.Field.ValueObjects
{
    public class CPF
    {
        public CPF()
        { }

        public CPF(string cpf)
        {           
            
            this.Value = cpf ?? throw new ArgumentNullException(nameof(cpf));

        }

        public string Value { get; set; }
        public string FormatValue => Format(this.Value);


        private string Format(string value) => Convert.ToInt64(value).ToString(@"000\.000\.000\-00");

        
    }
}
