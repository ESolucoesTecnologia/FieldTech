using FieldTech.Domain.Field;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FieldTech.Repository.Mapping
{
    public class TelefoneMapping : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.ToTable("Telefone");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Ddd).IsRequired();
            builder.Property(x => x.Numero).HasColumnType("varchar").HasMaxLength(10).IsRequired();
        }
    }
}
