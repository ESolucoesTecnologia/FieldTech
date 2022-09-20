using FieldTech.Domain.Fornecedor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FieldTech.Repository.Mapping
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>

    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(200).IsRequired();
            builder.Property(x => x.Cnpj).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Telefone).HasColumnType("varchar").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Endereco).HasColumnType("varchar").HasMaxLength(200).IsRequired(false);
            builder.Property(x => x.Cidade).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Estado).HasColumnType("varchar").HasMaxLength(2).IsRequired();
            
        }
    }
}
