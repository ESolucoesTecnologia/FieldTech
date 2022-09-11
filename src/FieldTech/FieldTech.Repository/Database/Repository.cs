using FieldTech.CrossCutting.Repository;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Linq.Expressions;

namespace FieldTech.Repository.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Task<IDbContextTransaction> CreateTransaction()
        {
            throw new NotImplementedException();
        }

        public Task<IDbContextTransaction> CreateTransaction(IsolationLevel isolation)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAllByCriteria(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindOneByCriteria(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Save(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }

}
