using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Application.OrdemServico.Dto
{
    public class OrdemOutputDto
    {
        public Guid Id { get; set; }
        public string Escopo { get; set; }
        public string Projeto { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime Dt_Acionamento { get; set; }
        public DateTime Dt_Agendamento { get; set; }
        public IList<OrdemDetalheOutputDto>? OrdemDetalheOutputList { get; set; }
        public Guid FornecedorId { get; set; }



    }
}
