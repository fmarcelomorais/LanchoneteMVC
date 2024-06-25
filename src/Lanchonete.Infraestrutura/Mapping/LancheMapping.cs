using Lanchonete.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lanchonete.Infraestrutura.Mapping
{
    public class LancheMapping : IEntityTypeConfiguration<Lanche>
    {
        public void Configure(EntityTypeBuilder<Lanche> builder)
        {
            builder.ToTable("Lanches");
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Nome)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
            builder.Property(l => l.Preco) 
                .IsRequired()
                .HasPrecision(10,2);
            builder.Property(l => l.DescricaoCurta)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(l => l.DescricaoLonga)
                .HasMaxLength(500)
                .IsRequired();
        }
    }
}
