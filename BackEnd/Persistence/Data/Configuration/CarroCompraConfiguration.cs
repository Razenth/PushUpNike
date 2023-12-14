using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuracion;
public class CarroCompraConfiguration : IEntityTypeConfiguration<Carrocompra>
{
    public void Configure(EntityTypeBuilder<Carrocompra> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("carrocompra");

        builder.HasIndex(e => e.UsuarioId, "usuario_id");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .HasColumnType("timestamp")
            .HasColumnName("fecha_creacion");
        builder.Property(e => e.UsuarioId).HasColumnName("usuario_id");

        builder.HasOne(d => d.Usuario).WithMany(p => p.Carrocompras)
            .HasForeignKey(d => d.UsuarioId)
            .HasConstraintName("carrocompra_ibfk_1");
    }
}