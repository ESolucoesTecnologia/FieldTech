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
    public class TecnicoMapping : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder.ToTable("Tb_Tecnico");
            builder.HasKey(t => t.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasColumnType("varchar").HasMaxLength(200);
            builder.Property(x => x.Rg).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.EstadoCivil).HasColumnType("varchar").HasMaxLength(20);
            builder.Property(x => x.CpfCnpj).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.OrgaoEmissor).HasColumnType("varchar").HasMaxLength(50);
            builder.HasMany(x => x.EnderecoList).WithOne();
            builder.HasMany(x => x.EmailList).WithOne();
            builder.HasMany(x => x.TelefoneList).WithOne();

        }
    }
}
