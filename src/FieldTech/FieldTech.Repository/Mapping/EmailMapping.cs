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
    public class EmailMapping : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> builder)
        {
            builder.ToTable("Tb_Email");
            builder.HasKey(e => e.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Endereco).IsRequired().HasColumnType("varchar").HasMaxLength(100);

           
        }
    }
}
