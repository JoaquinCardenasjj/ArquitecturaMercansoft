using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class PrimeraMigracionMercansoft : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MER_TBL_CLIENTE",
                columns: table => new
                {
                    CLI_ID_CLIENTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLI_NOMBRE = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CLI_TIPO_IDENTIFICACION = table.Column<int>(type: "int", nullable: false),
                    CLI_IDENTIFICACION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLI_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    CLI_ELIMINADO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CLI_ID_CLIENTE", x => x.CLI_ID_CLIENTE);
                });

            migrationBuilder.CreateTable(
                name: "MER_TBL_PRODUCTO",
                columns: table => new
                {
                    PRO_ID_PRODUCTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRO_NOMBRE = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    PRO_PRECIO = table.Column<double>(type: "float", nullable: false),
                    PRO_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    PRO_ELIMINADO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRO_ID_PRODUCTO", x => x.PRO_ID_PRODUCTO);
                });

            migrationBuilder.CreateTable(
                name: "MER_TBL_FACTURA",
                columns: table => new
                {
                    IdFactura = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FAC_FECHA_FACTURA = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "FECHA INICIAL DE LA FACTURA"),
                    FAC_CLIENTE_ID = table.Column<int>(type: "int", nullable: false),
                    FAC_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    FAC_ELIMINADO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("FAC_ID_FACTURA", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_CLI_FAC",
                        column: x => x.FAC_CLIENTE_ID,
                        principalTable: "MER_TBL_CLIENTE",
                        principalColumn: "CLI_ID_CLIENTE",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MER_TBL_ORDEN",
                columns: table => new
                {
                    ORD_FACTURA_ID = table.Column<int>(type: "int", nullable: false),
                    ORD_PRODUCTO_ID = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ORD_VALOR_TOTAL = table.Column<double>(type: "float", nullable: false, comment: "VALOR TOTAL DE LA ORDEN"),
                    ORD_ACTIVO = table.Column<bool>(type: "bit", nullable: false),
                    ORD_ELIMINADO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MER_TBL_ORDEN", x => new { x.ORD_FACTURA_ID, x.ORD_PRODUCTO_ID });
                    table.ForeignKey(
                        name: "FK_ORD_FAC",
                        column: x => x.ORD_FACTURA_ID,
                        principalTable: "MER_TBL_FACTURA",
                        principalColumn: "IdFactura",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORD_PRO",
                        column: x => x.ORD_PRODUCTO_ID,
                        principalTable: "MER_TBL_PRODUCTO",
                        principalColumn: "PRO_ID_PRODUCTO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MER_TBL_FACTURA_FAC_CLIENTE_ID",
                table: "MER_TBL_FACTURA",
                column: "FAC_CLIENTE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_MER_TBL_ORDEN_ORD_PRODUCTO_ID",
                table: "MER_TBL_ORDEN",
                column: "ORD_PRODUCTO_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MER_TBL_ORDEN");

            migrationBuilder.DropTable(
                name: "MER_TBL_FACTURA");

            migrationBuilder.DropTable(
                name: "MER_TBL_PRODUCTO");

            migrationBuilder.DropTable(
                name: "MER_TBL_CLIENTE");
        }
    }
}
