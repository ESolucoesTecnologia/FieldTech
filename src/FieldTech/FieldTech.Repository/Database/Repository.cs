using FieldTech.CrossCutting.Repository;
using FieldTech.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Linq.Expressions;

namespace FieldTech.Repository.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> Query { get; set; }
        protected DbContext Context { get; set; }
        public Repository(FieldTechContext fieldTechContext)
        {
            this.Context = fieldTechContext;
            this.Query = Context.Set<T>();
        }
        public async Task<IDbContextTransaction> CreateTransaction()
        {
            return await this.Context.Database.BeginTransactionAsync();
        }

        public async Task<IDbContextTransaction> CreateTransaction(System.Data.IsolationLevel isolation)
        {
            return await this.Context.Database.BeginTransactionAsync(isolation);
        }

        public async Task Delete(T entity)
        {
            this.Query.Remove(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllByCriteria(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await this.Query
                             .AsNoTrackingWithIdentityResolution()
                             .Where(expression)
                             .ToListAsync();
        }

        public async Task<T> FindOneByCriteria(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await this.Query
                           .AsNoTrackingWithIdentityResolution()
                           .FirstOrDefaultAsync(expression);
        }

        public async Task<T> Get(object id)
        {
            return await this.Query.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.Query
                             .AsNoTrackingWithIdentityResolution()
                             .ToListAsync();
        }

        public async Task Save(T entity)
        {
            await this.Query.AddAsync(entity);
            await this.Context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            this.Query.Update(entity);
            await this.Context.SaveChangesAsync();
        }
    }

}
