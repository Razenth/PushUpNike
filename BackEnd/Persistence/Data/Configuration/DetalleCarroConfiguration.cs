using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuracion;
public class DetalleCarroConfiguration : IEntityTypeConfiguration<Detallescarrocompra>
{
    public void Configure(EntityTypeBuilder<Detallescarrocompra> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("detallescarrocompra");

        builder.HasIndex(e => e.CarroId, "carro_id");

        builder.HasIndex(e => e.ProductoId, "producto_id");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Cantidad).HasColumnName("cantidad");
        builder.Property(e => e.CarroId).HasColumnName("carro_id");
        builder.Property(e => e.ProductoId).HasColumnName("producto_id");

        builder.HasOne(d => d.Carro).WithMany(p => p.Detallescarrocompras)
            .HasForeignKey(d => d.CarroId)
            .HasConstraintName("detallescarrocompra_ibfk_1");

        builder.HasOne(d => d.Producto).WithMany(p => p.Detallescarrocompras)
            .HasForeignKey(d => d.ProductoId)
            .HasConstraintName("detallescarrocompra_ibfk_2");
    }
}