using Microsoft.EntityFrameworkCore.Migrations;

namespace PapaBob.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Porudzbine",
                columns: table => new
                {
                    PorudzbinaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PorucilacIme = table.Column<string>(nullable: true),
                    Adressa = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Cena = table.Column<double>(nullable: false),
                    Datum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porudzbine", x => x.PorudzbinaId);
                });

            migrationBuilder.CreateTable(
                name: "Pizze",
                columns: table => new
                {
                    PorucenaPizzaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Velicina = table.Column<string>(nullable: true),
                    Kora = table.Column<string>(nullable: true),
                    Zacini = table.Column<string>(nullable: true),
                    Cena = table.Column<double>(nullable: false),
                    PorudzbinaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizze", x => x.PorucenaPizzaId);
                    table.ForeignKey(
                        name: "FK_Pizze_Porudzbine_PorudzbinaId",
                        column: x => x.PorudzbinaId,
                        principalTable: "Porudzbine",
                        principalColumn: "PorudzbinaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizze_PorudzbinaId",
                table: "Pizze",
                column: "PorudzbinaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizze");

            migrationBuilder.DropTable(
                name: "Porudzbine");
        }
    }
}
