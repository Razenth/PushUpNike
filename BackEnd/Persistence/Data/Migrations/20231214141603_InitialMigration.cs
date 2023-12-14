using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterDatabase()
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "categorias",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         nombre_categoria = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "productos",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         nombre_producto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         descripcion = table.Column<string>(type: "text", nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         precio = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
            //         existencias = table.Column<int>(type: "int", nullable: false),
            //         stock_minimo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'0'"),
            //         stock_maximo = table.Column<int>(type: "int", nullable: true, defaultValueSql: "'100'"),
            //         url_producto = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "roles",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         nombre_rol = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "Inventarios",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         ProductoId = table.Column<int>(type: "int", nullable: true),
            //         CantidadAnterior = table.Column<int>(type: "int", nullable: false),
            //         CantidadNueva = table.Column<int>(type: "int", nullable: false),
            //         FechaMovimiento = table.Column<DateTime>(type: "datetime(6)", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Inventarios", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_Inventarios_productos_ProductoId",
            //             column: x => x.ProductoId,
            //             principalTable: "productos",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "productoscategorias",
            //     columns: table => new
            //     {
            //         producto_id = table.Column<int>(type: "int", nullable: false),
            //         categoria_id = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => new { x.producto_id, x.categoria_id })
            //             .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
            //         table.ForeignKey(
            //             name: "productoscategorias_ibfk_1",
            //             column: x => x.producto_id,
            //             principalTable: "productos",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "productoscategorias_ibfk_2",
            //             column: x => x.categoria_id,
            //             principalTable: "categorias",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "usuarios",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         nombre_usuario = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         correo_electronico = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         contrasena = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         rol_id = table.Column<int>(type: "int", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "usuarios_ibfk_1",
            //             column: x => x.rol_id,
            //             principalTable: "roles",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "carrocompra",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         usuario_id = table.Column<int>(type: "int", nullable: true),
            //         fecha_creacion = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "carrocompra_ibfk_1",
            //             column: x => x.usuario_id,
            //             principalTable: "usuarios",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "pedidos",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         usuario_id = table.Column<int>(type: "int", nullable: true),
            //         fecha_pedido = table.Column<DateOnly>(type: "date", nullable: false),
            //         estado_pedido = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
            //             .Annotation("MySql:CharSet", "utf8mb4")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "pedidos_ibfk_1",
            //             column: x => x.usuario_id,
            //             principalTable: "usuarios",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "transacciones",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         usuario_id = table.Column<int>(type: "int", nullable: true),
            //         fecha_transaccion = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
            //         total = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "transacciones_ibfk_1",
            //             column: x => x.usuario_id,
            //             principalTable: "usuarios",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "usuarioscompras",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         usuario_id = table.Column<int>(type: "int", nullable: true),
            //         total_compras = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "usuarioscompras_ibfk_1",
            //             column: x => x.usuario_id,
            //             principalTable: "usuarios",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "detallescarrocompra",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         carro_id = table.Column<int>(type: "int", nullable: true),
            //         producto_id = table.Column<int>(type: "int", nullable: true),
            //         cantidad = table.Column<int>(type: "int", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "detallescarrocompra_ibfk_1",
            //             column: x => x.carro_id,
            //             principalTable: "carrocompra",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "detallescarrocompra_ibfk_2",
            //             column: x => x.producto_id,
            //             principalTable: "productos",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "detallespedido",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         pedido_id = table.Column<int>(type: "int", nullable: true),
            //         producto_id = table.Column<int>(type: "int", nullable: true),
            //         cantidad = table.Column<int>(type: "int", nullable: false),
            //         precio_unitario = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "detallespedido_ibfk_1",
            //             column: x => x.pedido_id,
            //             principalTable: "pedidos",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "detallespedido_ibfk_2",
            //             column: x => x.producto_id,
            //             principalTable: "productos",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "detallestransaccion",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false),
            //         transaccion_id = table.Column<int>(type: "int", nullable: true),
            //         producto_id = table.Column<int>(type: "int", nullable: true),
            //         cantidad = table.Column<int>(type: "int", nullable: false),
            //         precio_unitario = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PRIMARY", x => x.id);
            //         table.ForeignKey(
            //             name: "detallestransaccion_ibfk_1",
            //             column: x => x.transaccion_id,
            //             principalTable: "transacciones",
            //             principalColumn: "id");
            //         table.ForeignKey(
            //             name: "detallestransaccion_ibfk_2",
            //             column: x => x.producto_id,
            //             principalTable: "productos",
            //             principalColumn: "id");
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Inventarios_ProductoId",
            //     table: "Inventarios",
            //     column: "ProductoId");

            // migrationBuilder.CreateIndex(
            //     name: "usuario_id",
            //     table: "carrocompra",
            //     column: "usuario_id");

            // migrationBuilder.CreateIndex(
            //     name: "carro_id",
            //     table: "detallescarrocompra",
            //     column: "carro_id");

            // migrationBuilder.CreateIndex(
            //     name: "producto_id",
            //     table: "detallescarrocompra",
            //     column: "producto_id");

            // migrationBuilder.CreateIndex(
            //     name: "pedido_id",
            //     table: "detallespedido",
            //     column: "pedido_id");

            // migrationBuilder.CreateIndex(
            //     name: "producto_id1",
            //     table: "detallespedido",
            //     column: "producto_id");

            // migrationBuilder.CreateIndex(
            //     name: "producto_id2",
            //     table: "detallestransaccion",
            //     column: "producto_id");

            // migrationBuilder.CreateIndex(
            //     name: "transaccion_id",
            //     table: "detallestransaccion",
            //     column: "transaccion_id");

            // migrationBuilder.CreateIndex(
            //     name: "usuario_id1",
            //     table: "pedidos",
            //     column: "usuario_id");

            // migrationBuilder.CreateIndex(
            //     name: "categoria_id",
            //     table: "productoscategorias",
            //     column: "categoria_id");

            // migrationBuilder.CreateIndex(
            //     name: "usuario_id2",
            //     table: "transacciones",
            //     column: "usuario_id");

            // migrationBuilder.CreateIndex(
            //     name: "rol_id",
            //     table: "usuarios",
            //     column: "rol_id");

            // migrationBuilder.CreateIndex(
            //     name: "usuario_id3",
            //     table: "usuarioscompras",
            //     column: "usuario_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "Inventarios");

            // migrationBuilder.DropTable(
            //     name: "detallescarrocompra");

            // migrationBuilder.DropTable(
            //     name: "detallespedido");

            // migrationBuilder.DropTable(
            //     name: "detallestransaccion");

            // migrationBuilder.DropTable(
            //     name: "productoscategorias");

            // migrationBuilder.DropTable(
            //     name: "usuarioscompras");

            // migrationBuilder.DropTable(
            //     name: "carrocompra");

            // migrationBuilder.DropTable(
            //     name: "pedidos");

            // migrationBuilder.DropTable(
            //     name: "transacciones");

            // migrationBuilder.DropTable(
            //     name: "productos");

            // migrationBuilder.DropTable(
            //     name: "categorias");

            // migrationBuilder.DropTable(
            //     name: "usuarios");

            // migrationBuilder.DropTable(
            //     name: "roles");
        }
    }
}
