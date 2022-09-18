﻿using FieldTech.CrossCutting.Entity;

namespace FieldTech.Domain.Fornecedor
{
    public class Fornecedor : Entity<Guid>
    {
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Dt_Inclusao { get; set; }
        public DateTime Dt_Atualizacao { get; set; }



    }
}
