using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Registro_Con_Detalle.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    OrdenesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.OrdenesId);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesDetalle",
                columns: table => new
                {
                    OrdenesDetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrdenesId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    precio = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesDetalle", x => x.OrdenesDetalleId);
                    table.ForeignKey(
                        name: "FK_OrdenesDetalle_Ordenes_OrdenesId",
                        column: x => x.OrdenesId,
                        principalTable: "Ordenes",
                        principalColumn: "OrdenesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ProductoId", "Nombre" },
                values: new object[] { 1, "Coca-cola" });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ProductoId", "Nombre" },
                values: new object[] { 2, "Oreo" });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ProductoId", "Nombre" },
                values: new object[] { 3, "KitKat" });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ProductoId", "Nombre" },
                values: new object[] { 4, "Pringles" });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ProductoId", "Nombre" },
                values: new object[] { 5, "Snickers" });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "ProductoId", "Nombre" },
                values: new object[] { 6, "Pepsi" });

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesDetalle_OrdenesId",
                table: "OrdenesDetalle",
                column: "OrdenesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdenesDetalle");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Ordenes");
        }
    }
}
