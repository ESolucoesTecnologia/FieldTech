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
            // optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FieldTechContext).Assembly);
            base.OnModelCreating(modelBuilder);

            var keyProperties = modelBuilder
                        .Model
                        .GetEntityTypes()
                        .SelectMany(e => e.GetProperties())
                        .Where(p => p.DeclaringEntityType.ClrType.Name == "Dt_Inclusao")
                        .ToList();

            foreach (var p in keyProperties)
            {
                modelBuilder
                    .Entity(p.DeclaringEntityType.Name)
                    .Property(p.Name).HasColumnType("datetime").IsRequired();
            }




        }





    }
}
