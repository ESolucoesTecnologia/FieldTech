using FieldTech.Domain.Fornecedor;
using FieldTech.Domain.Fornecedor.Repository;
using FieldTech.Repository.Context;
using FieldTech.Repository.Database;

namespace FieldTech.Repository.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(FieldTechContext fieldTechContext) : base(fieldTechContext)
        {
        }
    }
}
