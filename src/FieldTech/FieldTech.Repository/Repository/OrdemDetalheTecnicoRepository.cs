using FieldTech.Domain.OrdemServico;
using FieldTech.Domain.OrdemServico.Repository;
using FieldTech.Repository.Context;
using FieldTech.Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Repository.Repository
{
    public class OrdemDetalheTecnicoRepository : Repository<OrdemDetalheTecnico>, IOrdemDetalheTecnicoRepository
    {
        public OrdemDetalheTecnicoRepository(FieldTechContext fieldTechContext) : base(fieldTechContext)
        {
        }
    }
}
