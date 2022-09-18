using FieldTech.Domain.OrdemServico;
using FieldTech.Domain.OrdemServico.Repository;
using FieldTech.Repository.Context;
using FieldTech.Repository.Database;

namespace FieldTech.Repository.Repository
{
    public class OrdemRepository : Repository<Ordem>, IOrdemRepository
    {
        public OrdemRepository(FieldTechContext fieldTechContext) : base(fieldTechContext)
        {
        }
    }
}
