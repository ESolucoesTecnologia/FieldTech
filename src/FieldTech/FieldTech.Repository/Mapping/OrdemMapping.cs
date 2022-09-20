using FieldTech.Domain.OrdemServico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Repository.Mapping
{
    public class OrdemMapping : IEntityTypeConfiguration<Ordem>
    {
        public void Configure(EntityTypeBuilder<Ordem> builder)
        {
            builder.ToTable("Ordem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Escopo).HasColumnType("ntext").IsRequired();
            builder.Property(x => x.Projeto).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Endereco).HasColumnType("varchar").HasMaxLength(200).IsRequired();
            builder.Property(x => x.Estado).HasColumnType("varchar").HasMaxLength(2).IsRequired();
            builder.Property(x => x.Cidade).HasColumnType("varchar").HasMaxLength(100).IsRequired();
            builder.HasMany(x => x.OrdemDetalheList).WithOne();
            builder.HasOne(x => x.Fornecedor);

        }
    }
}
