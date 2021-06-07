using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuyDominio.Entidades;
using System;

namespace QuickBuyRepositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(80);

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(60);

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);


        }
    }
}
