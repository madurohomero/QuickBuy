using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuyDominio.Entidades;
using System;

namespace QuickBuyRepositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder
                .HasKey(p => p.Id);
            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(80);

            builder
                .Property(p => p.NumeroEndereco)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(60);

            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(2);

            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(p => p.DataPedido)
                .IsRequired();

            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .HasOne(p => p.FormaPagamento);
                

        }
    }
}
