using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prueba_Parcial.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulo",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartamentoId = table.Column<int>(nullable: false),
                    Referencia = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Existencia = table.Column<int>(nullable: false),
                    Departamento = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulo", x => x.ArticuloId);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                columns: table => new
                {
                    DepartamentoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.DepartamentoId);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    PedidoId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(nullable: false),
                    ArticuloId = table.Column<int>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.PedidoId);
                });

            migrationBuilder.InsertData(
                table: "Articulo",
                columns: new[] { "ArticuloId", "Departamento", "DepartamentoId", "Descripcion", "Existencia", "Precio", "Referencia" },
                values: new object[] { 1, "Tecnologia", 1, "Iphone 2g", 2, 4000m, "Tecn" });

            migrationBuilder.InsertData(
                table: "Articulo",
                columns: new[] { "ArticuloId", "Departamento", "DepartamentoId", "Descripcion", "Existencia", "Precio", "Referencia" },
                values: new object[] { 2, "Tecnologia", 1, "Iphone 3g", 3, 5000m, "Tecn" });

            migrationBuilder.InsertData(
                table: "Articulo",
                columns: new[] { "ArticuloId", "Departamento", "DepartamentoId", "Descripcion", "Existencia", "Precio", "Referencia" },
                values: new object[] { 3, "Ferreteria", 2, "Tornillo Grande", 100, 15m, "Tool" });

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "DepartamentoId", "Descripcion" },
                values: new object[] { 1, "Tecnologia" });

            migrationBuilder.InsertData(
                table: "Departamento",
                columns: new[] { "DepartamentoId", "Descripcion" },
                values: new object[] { 2, "Ferreteria" });

            migrationBuilder.InsertData(
                table: "Pedido",
                columns: new[] { "PedidoId", "ArticuloId", "Cantidad", "Fecha", "Precio", "Total" },
                values: new object[] { 1, 1, 1, new DateTime(2020, 10, 25, 10, 23, 0, 358, DateTimeKind.Local).AddTicks(8320), 1m, 10m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulo");

            migrationBuilder.DropTable(
                name: "Departamento");

            migrationBuilder.DropTable(
                name: "Pedido");
        }
    }
}
