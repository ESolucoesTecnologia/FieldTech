using FieldTech.Domain.OrdemServico;
using FieldTech.Domain.OrdemServico.Repository;
using FieldTech.Repository.Context;
using FieldTech.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace FieldTech.Repository.Repository
{
    public class OrdemRepository : Repository<Ordem>, IOrdemRepository
    {
        public OrdemRepository(FieldTechContext fieldTechContext) : base(fieldTechContext)
        {
        }

        public async Task<Ordem> ObterPorId(Guid id)
        {

            return await this.Query.Where(x => x.Id == id)
                                    .Include(x => x.OrdemDetalheList.Select(p => p.OrdemDetalheTecnicoList))                                   
                                    .FirstAsync();
                                   


        }

    }
}
