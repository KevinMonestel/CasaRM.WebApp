using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasaRM.WebApp.Persistence.Migrations
{
    public partial class GuestHealthQuestionnaireRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstudiosSociales_CuestionariosSaludHuespedes_CuestionarioSaludHuespedId",
                table: "EstudiosSociales");

            migrationBuilder.DropTable(
                name: "CuestionariosSaludHuespedes");

            migrationBuilder.DropIndex(
                name: "IX_EstudiosSociales_CuestionarioSaludHuespedId",
                table: "EstudiosSociales");

            migrationBuilder.DropColumn(
                name: "CuestionarioSaludHuespedId",
                table: "EstudiosSociales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CuestionarioSaludHuespedId",
                table: "EstudiosSociales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CuestionariosSaludHuespedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pregunta1 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta10 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta11 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta12 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta13 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta14 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta15 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta16 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta17 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta18 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta19 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta2 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta3 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta4 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta5 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta6 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta7 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta8 = table.Column<bool>(type: "bit", nullable: false),
                    Pregunta9 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuestionariosSaludHuespedes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstudiosSociales_CuestionarioSaludHuespedId",
                table: "EstudiosSociales",
                column: "CuestionarioSaludHuespedId");

            migrationBuilder.AddForeignKey(
                name: "FK_EstudiosSociales_CuestionariosSaludHuespedes_CuestionarioSaludHuespedId",
                table: "EstudiosSociales",
                column: "CuestionarioSaludHuespedId",
                principalTable: "CuestionariosSaludHuespedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
