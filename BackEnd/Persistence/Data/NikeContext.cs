using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class NikeContext : DbContext
{
    public NikeContext(DbContextOptions<NikeContext> options) : base(options)
    {
    }
    public virtual DbSet<Carrocompra> Carrocompras { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Detallescarrocompra> Detallescarrocompras { get; set; }

    public virtual DbSet<Detallespedido> Detallespedidos { get; set; }

    public virtual DbSet<Detallestransaccion> Detallestransaccions { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Roles> Roles { get; set; }

    public virtual DbSet<Transacciones> Transacciones { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Usuarioscompra> Usuarioscompras { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}