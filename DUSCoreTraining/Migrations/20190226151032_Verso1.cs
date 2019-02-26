using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DUSCoreTraining.Migrations
{
    public partial class Verso1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rechnungs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(nullable: false),
                    KopfText = table.Column<string>(nullable: true),
                    KundenID = table.Column<int>(nullable: false),
                    Summe = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rechnungs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Positionens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RechnungID = table.Column<int>(nullable: false),
                    Anzahl = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Preis = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positionens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Positionens_Rechnungs_RechnungID",
                        column: x => x.RechnungID,
                        principalTable: "Rechnungs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Positionens_RechnungID",
                table: "Positionens",
                column: "RechnungID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positionens");

            migrationBuilder.DropTable(
                name: "Rechnungs");
        }
    }
}
