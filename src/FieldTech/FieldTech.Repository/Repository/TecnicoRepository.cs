using FieldTech.Domain.Field;
using FieldTech.Domain.Field.Repository;
using FieldTech.Repository.Context;
using FieldTech.Repository.Database;

namespace FieldTech.Repository.Repository
{
    public class TecnicoRepository : Repository<Tecnico>, ITecnicoRepository
    {
        public TecnicoRepository(FieldTechContext fieldTechContext) : base(fieldTechContext)
        {
        }
    }
}
