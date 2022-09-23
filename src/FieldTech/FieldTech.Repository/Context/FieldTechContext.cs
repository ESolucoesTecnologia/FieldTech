using Microsoft.EntityFrameworkCore;

namespace FieldTech.Repository.Context
{
    public class FieldTechContext : DbContext
    {
        public FieldTechContext(DbContextOptions<FieldTechContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FieldTechContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            // Configuração que pega todas as propriedades que são datetime e mapeiam para a coluna do tipo datetime
            configurationBuilder
                .Properties<DateTime>()
                .HaveColumnType("datetime");


            configurationBuilder
                .Properties<int>()
                .HaveColumnType("int");

            configurationBuilder
                .Properties<string>()
                .HaveColumnType("varchar");

        }

        public async  override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach(var entry in ChangeTracker.Entries().Where(
                entry => entry.Entity.GetType().GetProperty("Dt_Inclusao") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("Dt_Inclusao").CurrentValue = DateTime.Now;
                    entry.Property("Dt_Atualizacao").CurrentValue = DateTime.Now;
                }
                    



                 if (entry.State == EntityState.Modified)
                {
                    //Faz com que a data de cadastro não seja modificada, mesmo ela sendo preenchida por algum objeto de negocio
                    entry.Property("Dt_Inclusao").IsModified = false;

                    if (entry.Entity.GetType().GetProperty("Dt_Atualizacao") != null)
                        entry.Property("Dt_Atualizacao").CurrentValue = DateTime.Now;

                }
            }

            return await base.SaveChangesAsync();

        }




    }
}
