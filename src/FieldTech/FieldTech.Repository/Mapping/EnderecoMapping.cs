using FieldTech.Domain.Field;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Repository.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Logradouro).HasColumnType("varchar").HasMaxLength(200).IsRequired(false);
            builder.Property(x => x.Estado).HasColumnType("varchar").HasMaxLength(2).IsRequired(true);
            builder.Property(x => x.Cidade).HasColumnType("varchar").HasMaxLength(100).IsRequired(true);
            builder.Property(x => x.Complemento).HasColumnType("varchar").HasMaxLength(300).IsRequired(false);            
        }
    }
}
