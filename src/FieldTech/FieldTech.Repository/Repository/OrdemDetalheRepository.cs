using FieldTech.Domain.OrdemServico;
using FieldTech.Domain.OrdemServico.Repository;
using FieldTech.Repository.Context;
using FieldTech.Repository.Database;

namespace FieldTech.Repository.Repository
{
    public class OrdemDetalheRepository : Repository<OrdemDetalhe>, IOrdemDetalheRepository
    {
        public OrdemDetalheRepository(FieldTechContext fieldTechContext) : base(fieldTechContext)
        {
        }        

    }
}
