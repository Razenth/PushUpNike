using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuracion;
public class UsuariosCompraConfiguration : IEntityTypeConfiguration<Usuarioscompra>
{
    public void Configure(EntityTypeBuilder<Usuarioscompra> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("usuarioscompras");

        builder.HasIndex(e => e.UsuarioId, "usuario_id");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.TotalCompras)
            .HasPrecision(10, 2)
            .HasColumnName("total_compras");
        builder.Property(e => e.UsuarioId).HasColumnName("usuario_id");

        builder.HasOne(d => d.Usuario).WithMany(p => p.Usuarioscompras)
            .HasForeignKey(d => d.UsuarioId)
            .HasConstraintName("usuarioscompras_ibfk_1");
    }
}