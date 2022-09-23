using FieldTech.Domain.Field;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FieldTech.Repository.Mapping
{
    public class TecnicoMapping : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder.ToTable("Tecnico");
            builder.HasKey(t => t.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(200);
            builder.Property(x => x.Rg).HasColumnType("varchar").HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.EstadoCivil).HasColumnType("varchar").HasMaxLength(20).IsRequired(false);

            
            builder.OwnsOne(x => x.CpfCnpj, p =>
            {
                p.Property(e => e.Value)
                    .HasColumnName("CpfCnpj")                    
                    .HasMaxLength(20)
                    .IsRequired(false);
            });
            builder.Property(x => x.OrgaoEmissor).HasColumnType("varchar").HasMaxLength(50).IsRequired(false);                     
            builder.HasMany(x => x.EmailList).WithOne();
            builder.HasMany(x => x.TelefoneList).WithOne();
            builder.HasMany(x => x.EnderecoList).WithOne();

        }
    }
}
