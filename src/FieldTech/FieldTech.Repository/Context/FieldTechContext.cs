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
            //optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FieldTechContext).Assembly);

            var keyPropertiesInclusao = modelBuilder
                        .Model
                        .GetEntityTypes()
                        .SelectMany(e => e.GetProperties())
                        .Where(p => p.DeclaringEntityType.ClrType.Name == "Dt_Inclusao")
                        .ToList();

            foreach (var p in keyPropertiesInclusao)
            {
                modelBuilder
                    .Entity(p.DeclaringEntityType.Name)
                    .Property(p.Name).HasColumnType("datetime").IsRequired(true);
            }

            var keyPropertiesAtualizacao = modelBuilder
                   .Model
                   .GetEntityTypes()
                   .SelectMany(e => e.GetProperties())
                   .Where(p => p.DeclaringEntityType.ClrType.Name == "Dt_Atualizacao")
                   .ToList();

            foreach (var p in keyPropertiesAtualizacao)
            {
                modelBuilder
                    .Entity(p.DeclaringEntityType.Name)
                    .Property(p.Name).HasColumnType("datetime").IsRequired(false);
            }




            base.OnModelCreating(modelBuilder);
        }


        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            // Configuração que pega todas as propriedades que são datetime e mapeiam para a coluna do tipo datetime
            configurationBuilder
                .Properties<DateTime>()
                .HaveColumnType("datetime");
                
                

        }

    }
}
