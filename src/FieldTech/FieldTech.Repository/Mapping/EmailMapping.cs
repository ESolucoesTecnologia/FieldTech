using FieldTech.Domain.Field;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FieldTech.Repository.Mapping
{
    public class EmailMapping : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("Email");
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.OwnsOne(x => x.Endereco, p =>
            {
                p.Property(e => e.Valor).HasColumnName("Endereco").HasMaxLength(100).IsRequired();
            });


        }
    }
}
