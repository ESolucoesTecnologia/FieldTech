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





        }

    }
}
