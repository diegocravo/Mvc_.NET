using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Infrastructure.Migrations
{
    public partial class AddedMoleculeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moleculas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rendimento = table.Column<decimal>(nullable: false),
                    FormulaMolecular = table.Column<string>(nullable: true),
                    TipoReacao = table.Column<string>(nullable: true),
                    Lancamento = table.Column<DateTime>(nullable: false),
                    AutorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moleculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moleculas_Autores_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Moleculas_AutorId",
                table: "Moleculas",
                column: "AutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moleculas");
        }
    }
}
