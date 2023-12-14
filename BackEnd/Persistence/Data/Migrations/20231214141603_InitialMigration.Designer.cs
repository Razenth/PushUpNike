﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(NikeContext))]
    [Migration("20231214141603_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Carrocompra", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("fecha_creacion")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "UsuarioId" }, "usuario_id");

                    b.ToTable("carrocompra", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("NombreCategoria")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_categoria");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("categorias", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Detallescarrocompra", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int?>("CarroId")
                        .HasColumnType("int")
                        .HasColumnName("carro_id");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int")
                        .HasColumnName("producto_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "CarroId" }, "carro_id");

                    b.HasIndex(new[] { "ProductoId" }, "producto_id");

                    b.ToTable("detallescarrocompra", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Detallespedido", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int")
                        .HasColumnName("pedido_id");

                    b.Property<decimal>("PrecioUnitario")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("precio_unitario");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int")
                        .HasColumnName("producto_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "PedidoId" }, "pedido_id");

                    b.HasIndex(new[] { "ProductoId" }, "producto_id")
                        .HasDatabaseName("producto_id1");

                    b.ToTable("detallespedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Detallestransaccion", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<decimal>("PrecioUnitario")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("precio_unitario");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int")
                        .HasColumnName("producto_id");

                    b.Property<int?>("TransaccionId")
                        .HasColumnType("int")
                        .HasColumnName("transaccion_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "ProductoId" }, "producto_id")
                        .HasDatabaseName("producto_id2");

                    b.HasIndex(new[] { "TransaccionId" }, "transaccion_id");

                    b.ToTable("detallestransaccion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CantidadAnterior")
                        .HasColumnType("int");

                    b.Property<int>("CantidadNueva")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaMovimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.ToTable("Inventarios");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("EstadoPedido")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("estado_pedido");

                    b.Property<DateOnly>("FechaPedido")
                        .HasColumnType("date")
                        .HasColumnName("fecha_pedido");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "UsuarioId" }, "usuario_id")
                        .HasDatabaseName("usuario_id1");

                    b.ToTable("pedidos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .HasColumnType("text")
                        .HasColumnName("descripcion");

                    b.Property<int>("Existencias")
                        .HasColumnType("int")
                        .HasColumnName("existencias");

                    b.Property<string>("NombreProducto")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombre_producto");

                    b.Property<decimal>("Precio")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("precio");

                    b.Property<int?>("StockMaximo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("stock_maximo")
                        .HasDefaultValueSql("'100'");

                    b.Property<int?>("StockMinimo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("stock_minimo")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("UrlProducto")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("url_producto");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("productos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Roles", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("NombreRol")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_rol");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Transacciones", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("FechaTransaccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("fecha_transaccion")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<decimal>("Total")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("total");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "UsuarioId" }, "usuario_id")
                        .HasDatabaseName("usuario_id2");

                    b.ToTable("transacciones", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Contrasena")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("contrasena");

                    b.Property<string>("CorreoElectronico")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("correo_electronico");

                    b.Property<string>("NombreUsuario")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre_usuario");

                    b.Property<int?>("RolId")
                        .HasColumnType("int")
                        .HasColumnName("rol_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "RolId" }, "rol_id");

                    b.ToTable("usuarios", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Usuarioscompra", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<decimal>("TotalCompras")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("total_compras");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "UsuarioId" }, "usuario_id")
                        .HasDatabaseName("usuario_id3");

                    b.ToTable("usuarioscompras", (string)null);
                });

            modelBuilder.Entity("Productoscategoria", b =>
                {
                    b.Property<int>("ProductoId")
                        .HasColumnType("int")
                        .HasColumnName("producto_id");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("categoria_id");

                    b.HasKey("ProductoId", "CategoriaId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "CategoriaId" }, "categoria_id");

                    b.ToTable("productoscategorias", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Carrocompra", b =>
                {
                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany("Carrocompras")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("carrocompra_ibfk_1");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Detallescarrocompra", b =>
                {
                    b.HasOne("Domain.Entities.Carrocompra", "Carro")
                        .WithMany("Detallescarrocompras")
                        .HasForeignKey("CarroId")
                        .HasConstraintName("detallescarrocompra_ibfk_1");

                    b.HasOne("Domain.Entities.Producto", "Producto")
                        .WithMany("Detallescarrocompras")
                        .HasForeignKey("ProductoId")
                        .HasConstraintName("detallescarrocompra_ibfk_2");

                    b.Navigation("Carro");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Domain.Entities.Detallespedido", b =>
                {
                    b.HasOne("Domain.Entities.Pedido", "Pedido")
                        .WithMany("Detallespedidos")
                        .HasForeignKey("PedidoId")
                        .HasConstraintName("detallespedido_ibfk_1");

                    b.HasOne("Domain.Entities.Producto", "Producto")
                        .WithMany("Detallespedidos")
                        .HasForeignKey("ProductoId")
                        .HasConstraintName("detallespedido_ibfk_2");

                    b.Navigation("Pedido");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Domain.Entities.Detallestransaccion", b =>
                {
                    b.HasOne("Domain.Entities.Producto", "Producto")
                        .WithMany("Detallestransaccions")
                        .HasForeignKey("ProductoId")
                        .HasConstraintName("detallestransaccion_ibfk_2");

                    b.HasOne("Domain.Entities.Transacciones", "Transaccion")
                        .WithMany("Detallestransaccions")
                        .HasForeignKey("TransaccionId")
                        .HasConstraintName("detallestransaccion_ibfk_1");

                    b.Navigation("Producto");

                    b.Navigation("Transaccion");
                });

            modelBuilder.Entity("Domain.Entities.Inventario", b =>
                {
                    b.HasOne("Domain.Entities.Producto", "Producto")
                        .WithMany("Inventarios")
                        .HasForeignKey("ProductoId");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("pedidos_ibfk_1");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Transacciones", b =>
                {
                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany("Transacciones")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("transacciones_ibfk_1");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.HasOne("Domain.Entities.Roles", "Rol")
                        .WithMany("Usuarios")
                        .HasForeignKey("RolId")
                        .HasConstraintName("usuarios_ibfk_1");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Domain.Entities.Usuarioscompra", b =>
                {
                    b.HasOne("Domain.Entities.Usuario", "Usuario")
                        .WithMany("Usuarioscompras")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("usuarioscompras_ibfk_1");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Productoscategoria", b =>
                {
                    b.HasOne("Domain.Entities.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .IsRequired()
                        .HasConstraintName("productoscategorias_ibfk_2");

                    b.HasOne("Domain.Entities.Producto", null)
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .IsRequired()
                        .HasConstraintName("productoscategorias_ibfk_1");
                });

            modelBuilder.Entity("Domain.Entities.Carrocompra", b =>
                {
                    b.Navigation("Detallescarrocompras");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Navigation("Detallespedidos");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Navigation("Detallescarrocompras");

                    b.Navigation("Detallespedidos");

                    b.Navigation("Detallestransaccions");

                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Domain.Entities.Roles", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("Domain.Entities.Transacciones", b =>
                {
                    b.Navigation("Detallestransaccions");
                });

            modelBuilder.Entity("Domain.Entities.Usuario", b =>
                {
                    b.Navigation("Carrocompras");

                    b.Navigation("Pedidos");

                    b.Navigation("Transacciones");

                    b.Navigation("Usuarioscompras");
                });
#pragma warning restore 612, 618
        }
    }
}
